using CapaDatos.Modelos;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace CapaDatos
{
    public class usuarios
    {
        private const string SERVICE_BASE_URL = "https://tiusr3pl.cuc-carrera-ti.ac.cr/ProyectoPPII/api/";


        public string InicioSesion(ModelLogin usuario)
        {
            MensajeJson mensaje = new MensajeJson();
            try
            {
                string url = SERVICE_BASE_URL + "Usuarios/InicioSesion?identificacion=" + usuario.identificacion + "&contrasenna=" + usuario.contrasenna;
                string json = usuario.ToJsonString();
                using (var client = new HttpClient())
                {
                    var task = Task.Run(async () =>
                    {
                        return await client.PostAsync(
                            url,
                            new StringContent(json, Encoding.UTF8, "application/json")
                        );
                    }
                    );
                    HttpResponseMessage message = task.Result;
                    if (message.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var task2 = Task<string>.Run(async () =>
                        {
                            return await message.Content.ReadAsStringAsync();
                        }
);
                        string resultStr = task2.Result;

                        string newstr = resultStr.Replace("\"", "");
                        return newstr;

                    }
                    else if (message.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    {
                        return "Usuario y/o contraseña incorrectos.";
                    }
                    else if(message.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        return "El usuario no existe.";
                    }
                    else
                    {
                        var task2 = Task<string>.Run(async () =>
                        {
                            return await message.Content.ReadAsStringAsync();
                        });
                        string mens = task2.Result;
                        ModelError error = JsonConvert.DeserializeObject<ModelError>(mens);
                        return error.Exceptionmessage;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string crearUsuarios(ModelUsuario usuario)
        {
            string url = SERVICE_BASE_URL + "Usuarios";
            try
            {
                string json = usuario.ToJsonString();
                using (var client = new HttpClient())
                {
                    var task = Task.Run(async () =>
                    {
                        return await client.PostAsync(
                            url,
                            new StringContent(json, Encoding.UTF8, "application/json")
                        );
                    }
                    );
                    HttpResponseMessage message = task.Result;
                    if (message.StatusCode == System.Net.HttpStatusCode.Created)
                    {
                        return "1";
                    }
                    else if (message.StatusCode == System.Net.HttpStatusCode.Conflict)
                    {
                        return "El usuario ya se encuentra registrado";
                    }
                    else
                    {
                        var task2 = Task<string>.Run(async () =>
                        {
                            return await message.Content.ReadAsStringAsync();
                        });
                        string mens = task2.Result;
                        return mens;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
