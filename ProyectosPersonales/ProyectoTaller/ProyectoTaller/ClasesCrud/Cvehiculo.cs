using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ProyectoTaller
{
     class Cvehiculo
    {

        Conexion.db_TallerEntities dbTaller = new Conexion.db_TallerEntities();

        public void agregar(Conexion.Vehiculos vehiculoAdd) {
            try
            {
                
                
                    dbTaller.Vehiculos.Add(vehiculoAdd);
                    dbTaller.SaveChanges();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        
        }
        public List<Conexion.Vehiculos> Leer() {

            try
            {

                return dbTaller.Vehiculos.ToList();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }   
        
        
        
        }
        public void actualizar(Conexion.Vehiculos vehiculosMod) {

            try
            {
                dbTaller.Entry(vehiculosMod).State = EntityState.Modified;
                dbTaller.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        }
        public void borrar(int vid)
        {

            try
            {

                dbTaller.Vehiculos.Remove(dbTaller.Vehiculos.Single(x => x.id_vehiculo == vid));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

    }
}
