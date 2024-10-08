﻿using System;
namespace Memoria
{
    public abstract class MemoriaAbs
    {
        protected const int MAX = 20;
        protected const int NULO = -1;

        protected struct NodoM
        {
            public int dato;
            public int link;
        }
        protected NodoM[] MEM = new NodoM[MAX];
        protected int libre;

        public MemoriaAbs()
        {
            int i = 0;
            while (i < MEM.Length)
            {
                MEM[i].link = i + 1;

                i++;
            }
            MEM[MAX - 1].link = -1;
            libre = 0;
        }

        public abstract void mostrar();
        public abstract int new_espacio(int cantidad);
        public abstract void DeleteEspacio(int dir);
        public abstract int EspacioDisponible();
        public abstract int EspacioOcupado();
        public abstract bool DireccionLibre(int dir);
        public abstract void PonerDato(int dir, int lugar, int valor);
        public abstract int ObtenerDato(int dir, int lugar);
    }
}