import fetch from 'node-fetch';

export async function fetchInterpolData({ razonSocial, nombreComercial }) {
    //TODO: For now it only uses razonSocial
    const baseUrl = 'https://ws-public.interpol.int/notices/v1/red';
    const params = new URLSearchParams();

    const razonSocialParts = razonSocial.split(" ").map(part => part.trim());
    
    if (razonSocialParts.length > 0) params.append('forename', razonSocial.split(" ")[0]);
    if (razonSocialParts.length > 1) params.append('name', razonSocial.split(" ").slice(1).join(" "));
    params.append('resultPerPage', '160');

    const url = `${baseUrl}?${params.toString()}`;

    const response = await fetch(url, {
        headers: {
            'User-Agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:137.0) Gecko/20100101 Firefox/137.0'
        }
    });

    if (!response.ok) {
        throw new Error(`Error ${response.status}: ${response.statusText}`);
    }

    const data = await response.json();

    return data._embedded.notices.map((notice, idx) => ({
        id: idx,
        name: notice.name,
        forename: notice.forename,
        nationalities: notice.nationalities,
        dateOfBirth: notice.date_of_birth,
        link: notice._links.self.href,
    }));
}