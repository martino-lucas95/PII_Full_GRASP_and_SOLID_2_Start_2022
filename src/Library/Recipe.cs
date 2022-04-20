//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }
        /*Utilizo Expert ya que conoce todos los pasos (es la encargada de agregarlos o eliminarlos), obtiene el costo de la clase Step, y con estos datos puede determinar el costo total de produccion e imprimirlo en consola*/

        public double GetProductionCost()
        {
            double result = 0;

            foreach (Step step in this.steps)
            {
                result = result + step.GetstepCost();
            }

            return result;
        }

        /*Se mantiene el texto para imprimir en Recipe dado que es quien conoce toda la informacion necesaria de la receta para colaborar con la impresora y que la misma pueda imprimir ese texto*/
        public string TextToPrint()
        {
            string result = ($"Receta de {this.FinalProduct.Description}:\n");
            foreach (Step step in this.steps)
            {
                result += ($"{step.Quantity} de {step.Input.Description} usando {step.Equipment.Description} durante {step.Time} || Sub-Total: $ {step.GetstepCost()}\n");
            }
            result += ($"Costo Total: $ {GetProductionCost()}");
            return result;
        }
    }
}