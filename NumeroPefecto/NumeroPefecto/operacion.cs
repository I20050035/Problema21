using System;
using System.Collections.Generic;
using System.Text;

namespace NumeroPefecto
{
    class operacion
    {
        int num;
        public void Num_set(int valor)
        {
            num = valor;
        }
        public void calcular()
        {
            int i, s = 0;

            //Ciclo for para verificar si el numero es perfecto; 

            for (i = 1; i < num; i++)
            {

                if (num % i == 0) s = s + i;

            }
            if (s == num)

                System.Windows.Forms.MessageBox.Show("El numero Ingresado es Perfecto");
            else

                System.Windows.Forms.MessageBox.Show("El numero Ingresado no es Perfecto");

        }


    }
       

        
}
    

