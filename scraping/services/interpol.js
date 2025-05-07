import fetch from "node-fetch";

function getPermutation(string) {
	const parts = string.split(" ");
	const permutations = [];

	const n = parts.length;
	permutations.push({
		forename: "",
		familyName: string,
	});
	for (let i = 0; i < n; i++) {
		for (let j = i + 1; j <= n; j++) {
			const part = parts.slice(i, j).join(" ");
			const rest = [...parts.slice(0, i), ...parts.slice(j)].join(" ");
			permutations.push({
				forename: part,
				familyName: rest,
			});
		}
	}
	return permutations;
}

export async function fetchInterpolData({ razonSocial, nombreComercial }) {
	const baseUrl = "https://ws-public.interpol.int/notices/v1/red";
	const searchInputs = [razonSocial, nombreComercial];

	const hits = [];
	for (let i = 0; i < searchInputs.length; i++) {
		const currentInput = searchInputs[i];

		if (!currentInput || currentInput === "") continue;

		const currentInputPermutations = getPermutation(currentInput);

		for (let j = 0; j < currentInputPermutations.length; j++) {
			const params = new URLSearchParams();

			const { forename, familyName } = currentInputPermutations[j];

			if (forename.length !== 0) params.append("forename", forename);
			if (familyName.length !== 0) params.append("name", familyName);
			params.append("resultPerPage", "160");

			const url = `${baseUrl}?${params.toString()}`;

			const response = await fetch(url, {
				headers: {
					"User-Agent":
						"Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:137.0) Gecko/20100101 Firefox/137.0",
				},
			});

			if (!response.ok) {
				continue;
			}

			const data = await response.json();
			const currentHits = data._embedded.notices.map((notice, idx) => ({
				id: idx,
				familyName: notice.name,
				forename: notice.forename,
				nationalities: notice.nationalities,
				dateOfBirth: notice.date_of_birth,
				link: notice._links.self.href,
			}));
			hits.push(...currentHits);
		}
	}

	const uniqueHitsMap = new Map();
	for (const hit of hits) {
		if (!uniqueHitsMap.has(hit.link)) {
			uniqueHitsMap.set(hit.link, hit);
		}
	}
	return Array.from(uniqueHitsMap.values());
}
