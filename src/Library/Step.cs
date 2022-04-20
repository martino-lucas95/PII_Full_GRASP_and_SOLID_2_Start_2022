//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        /*La clase Step es quien conoce el costo de cada paso, ya que conoce las cantidades/horas y costos por insumo/horas maquina, por lo tanto cumple con el patron EXPERT ya que es quién tiene toda la información necesaria para cumplir con este método.*/
        public double GetstepCost()
        {
            return (this.Input.UnitCost * this.Quantity) + (this.Equipment.HourlyCost * this.Time);
        }
        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }
    }
}