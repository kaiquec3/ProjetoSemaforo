using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_de_semaforo
{
	class Semaforo
	{
		private byte estado;

		public Semaforo()
		{
			this.estado = 129;
		}

		public void setVerde(int rua)
		{
			int eraser = 465 - rua * 217;
			int setter = rua * 31 - 30;
			this.estado = (byte)((int)this.estado & eraser);
			this.estado = (byte)((int)this.estado | setter);
		}

		public void setAmarelo(int rua)
		{
			int eraser = 465 - rua * 217;
			int setter = rua * 62 - 60;
			this.estado = (byte)((int)this.estado & eraser);
			this.estado = (byte)((int)this.estado | setter);
		}

		public void setVermelho(int rua)
		{
			int eraser = 465 - rua * 217;
			int setter = rua * 124 - 120;
			this.estado = (byte)((int)this.estado & eraser);
			this.estado = (byte)((int)this.estado | setter);
		}

		public byte getEstado()
		{
			return this.estado;
		}

		public int getEstado(int rua)
		{
			int estado2=0;
			int valor = rua * 31 - 30;
	

	for (int n = 0; n <= 2; n++)
			{
				double k = Math.Pow(2, n);
				double m =(int)this.estado & (byte)(k * valor);
			   if (m == (k * valor))
				{
					estado2 = n + 1;
					break;
				}
			}
			return estado2;

		}
	}
}
