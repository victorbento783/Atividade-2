using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_2___Marlão
{
    class Conversão_de_medidas
    {
        private double Quilometro;
        private double Metro;
        private double Centimetro;
        private double Milimetro;
        private double Micrometro;
        private double Nanometro;
        private double Milha;
        private double Jarda;
        private double Pe;
        private double Polegada;
        private double Milhanautica;
        private double medida;

        public Conversão_de_medidas(double medida)
        {
            this.medida = medida;
        }

        public double Km
        {
            get
            { return Quilometro; }
            set
            {
                Quilometro = value;
                Metro = value * 1000;
                Centimetro = value * 100000;
                Milimetro = value * 1000000;
                Micrometro = value * 1000000000;
                Nanometro = value * 10000000000000;
                Milha = value / 1.60934;
                Jarda = value * 1094;
                Pe = value * 3281;
                Polegada = value * 39370;
                Milhanautica = value / 1.852;

            }
        }
        public double M
        {
            get
            { return Metro; }
            set
            {
                Quilometro = value / 1000;
                Metro = value;
                Centimetro = value * 100;
                Milimetro = value * 1000;
                Micrometro = value * 1000000;
                Nanometro = value * 1000000000;
                Milha = value / 1609.34;
                Jarda = value * 1.09361;
                Pe = value * 3.281;
                Polegada = value * 39.37;
                Milhanautica = value / 1852;

            }
        }
        public double Cm
        {
            get
            { return Centimetro; }
            set
            {
                Quilometro = value / 100000;
                Metro = value / 100;
                Centimetro = value;
                Milimetro = value * 10;
                Micrometro = value * 10000;
                Nanometro = value * 10000000;
                Milha = value / 160934;
                Jarda = value / 91.94;
                Pe = value / 30.48;
                Polegada = value / 2.54;
                Milhanautica = value / 185200;

            }
        }
        public double Mm
        {
            get
            { return Milimetro; }
            set
            {
                Quilometro = value / 1000000;
                Metro = value / 1000;
                Centimetro = value / 10;
                Milimetro = value;
                Micrometro = value * 1000;
                Nanometro = value * 1000000;
                Milha = value / 1609344000;
                Jarda = value / 914;
                Pe = value / 305;
                Polegada = value / 25.4;
                Milhanautica = value / 1852000000;

            }
        }
        public double Mc
        {
            get
            { return Micrometro; }
            set
            {
                Quilometro = value / 1000000000;
                Metro = value / 1000000;
                Centimetro = value / 10000;
                Milimetro = value / 1000;
                Micrometro = value;
                Nanometro = value * 1000;
                Milha = value / 160934400000;
                Jarda = value / 914400;
                Pe = value / 304800;
                Polegada = value / 25400;
                Milhanautica = value / 1852000000;

            }
        }
        public double Nm
        {
            get
            { return Nanometro; }
            set
            {
                Quilometro = value / 1000000000000;
                Metro = value / 1000000000;
                Centimetro = value / 10000000;
                Milimetro = value / 1000000;
                Micrometro = value / 1000;
                Nanometro = value;
                Milha = value / 160934400000000;
                Jarda = value / 914400000000;
                Pe = value / 304800000000;
                Polegada = value / 2540000000;
                Milhanautica = value / 1852000000000;
            }
        }
        public double Ml
        {
            get
            { return Milha; }
            set
            {
                Quilometro = value * 1.60934;
                Metro = value * 1609.34;
                Centimetro = value * 160934;
                Milimetro = value * 160934400;
                Micrometro = value * 1609344000000;
                Nanometro = value * 1609344000000000000;
                Milha = value;
                Jarda = value * 1760;
                Pe = value * 5280;
                Polegada = value * 63360;
                Milhanautica = value / 1.51;
            }
        }
        public double J
        {
            get
            { return Jarda; }
            set
            {
                Quilometro = value / 1094;
                Metro = value / 1.094;
                Centimetro = value * 91.94;
                Milimetro = value * 914;
                Micrometro = value * 9141400;
                Nanometro = value * 914400000000;
                Milha = value;
                Jarda = value / 1760;
                Pe = value * 3;
                Polegada = value * 36;
                Milhanautica = value / 2025;
            }
        }
        public double P
        {
            get
            { return Pe; }
            set
            {
                Quilometro = value / 3281;
                Metro = value / 3.281;
                Centimetro = value * 30.48;
                Milimetro = value * 305;
                Micrometro = value * 304800;
                Nanometro = value * 304800000000;
                Milha = value / 5280;
                Jarda = value / 3;
                Pe = value;
                Polegada = value * 12;
                Milhanautica = value / 6076;
            }
        }
        public double Pl
        {
            get
            { return Polegada; }
            set
            {
                Quilometro = value / 39370;
                Metro = value / 39.37;
                Centimetro = value * 2.54;
                Milimetro = value * 25.4;
                Micrometro = value * 25400;
                Nanometro = value * 2540000000;
                Milha = value / 63360;
                Jarda = value / 36;
                Pe = value / 12;
                Polegada = value;
                Milhanautica = value / 72913;
            }
        }
        public double Mn
        {
            get
            { return Milhanautica; }
            set
            {
                Quilometro = value * 1.852;
                Metro = value * 1852;
                Centimetro = value * 185200;
                Milimetro = value * 1852000000;
                Micrometro = value * 1852000000000;
                Nanometro = value * 1852000000000000;
                Milha = value * 1.151;
                Jarda = value * 2025;
                Pe = value * 6076;
                Polegada = value * 72913;
                Milhanautica = value;
            }
        }
    }
}
