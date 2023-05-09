using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

class Empresa
{
    public int ID;
    public string ApellidoP;
    public string ApellidoM;
    public string Nombre;
    public DateTime FechaI;
}

class PersoanalContratado : Empresa
{
    public int añoslaborados;
    public double porcentajeadicional;

    public PersonalContratado(int id, string apellidoPaterno, string apellidoMaterno, string nombre, DateTime fechaIngreso, double salario, int añosLaborados)
    {
        this.ID = id;
        this.apellidoPaterno = apellidoPaterno;
        this.apellidoMaterno = apellidoMaterno;
        this.nombre = nombre;
        this.fechaIngreso = fechaIngreso;
        this.añoslaborados = añosLaborados;

        if (añosLaborados >= 0 && añosLaborados <= 3)
        {
            this.porcentajeadicional = 0.05;
        }
        else if (añosLaborados >= 4 && añosLaborados <= 7)
        {
            this.porcentajeadicional = 0.10;
        }
        else if (añosLaborados >= 8 && añosLaborados <= 15)
        {
            this.porcentajeadicional = 0.15;
        }
        else if (añosLaborados > 15)
        {
            this.porcentajeadicional = 0.20;
        }
    }
}

class PersonalAdestajo : Empresa
{
    public int clientesCaptados;

    public PersonalAdestajo(int id, string apellidoPaterno, string apellidoMaterno, string nombre, DateTime fechaIngreso, double salario, int clientesCaptados)
    {

        this.ID = id;
        this.apellidoPaterno = apellidoPaterno;
        this.apellidoMaterno = apellidoMaterno;
        this.Nombre = nombre;
        this.fechaIngreso = fechaIngreso;
        this.salario = salario;
        this.clientesCapatados = clientesCaptados;
    }

    public void CalcularSalario()
    {
        this.salario = this.salario + (this.clientesCaptados * 130.0);

    }

}
