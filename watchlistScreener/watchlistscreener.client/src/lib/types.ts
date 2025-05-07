export type Proveedor = {
	id: string;
	razonSocial: string;
	nombreComercial: string;
	identificacionTributaria: number;
	numeroTelefonico: string;
	correoElectronico: string;
	sitioWeb: string;
	direccionFisica: string;
	paisId: string;
	pais?: Pais;
	facturacionAnual: number;
	fechaUltimaEdicion: string;
};

export type Pais = {
	id: string;
	nombre: string;
	codigo: string;
};

export type ScreeningResultTable = {
	sourceName: string;
	hits: string;
};

export type SMVHit = {
	id: string;
	fecha: string;
	sancionado: string;
	detalle: string;
	tipo: string;
	monto: string;
};

export type SecopHit = {
	id: string;
	documentoContratista: string;
	nombreContratista: string;
	valorSancion: string;
	fechaDePublicacion: string;
};

export type InterpolHit = {
	id: string;
	familyName: string;
	forename: string;
	nationalities: string[];
	dateOfBirth: string;
	link: string;
};

export type ScreeningData = {
	smv: SMVHit[];
	secop: SecopHit[];
	interpol: InterpolHit[];
};
