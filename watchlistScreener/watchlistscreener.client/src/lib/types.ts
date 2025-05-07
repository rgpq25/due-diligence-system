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
}

export type Pais = {
    id: string;
    nombre: string;
    codigo: string;
}