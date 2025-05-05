export type Proveedor = {
    id: string;
    razonSocial: string;
    nombreComercial: number;
    identifcacionTributaria: number;
    numeroTelefonico: string;
    correoElectronico: string;
    sitioWeb: string;
    direccionFisica: string;
    paisId: string;
    pais?: Pais;
    facturacionAnual: number;
}

export type Pais = {
    id: string;
    nombre: string;
    codigo: string;
}