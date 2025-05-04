import React from 'react';
import { Button } from './ui/Button';

export function Home() {
    return (
        <div className='p-5'>
            <h1 className="text-3xl font-bold">Bienvenido, Renzo</h1>
            <p className='text-muted-foreground text-md'>Gestiona tus proveedores y supervisa su estado a traves de diferentes listados globales.</p>
            <Button className='mt-5' variant='outline'>Crear Proveedor</Button>
      </div>
    );
}
