# PruebaFinaktiva
Repositorio para prueba back-end Finaktiva

# Desarrollo 
Esta prueba fue desarrollada en Netcore 3.1 y SQL Server 2019, utilizando el JWT Authentication para el envió de token

# Instalación
1) descargar proyecto del repositorio 
2) Crear la bd PruebaFinaktiva y ejecutar el script que se encuentra en la carpeta bd , en esta se encuentra el script para la creación de las tablas
3) cambiar el ConnectionStrings dentro del archivo appsettings.json del proyecto PruebaFinaktiva
4) abrir con postman el archivo que se encuentra en la carpeta collection, el cual contiene las peticiones de la Api y sus respetivos ejemplos (Login, getUser, CreateUser, UpdateUser y  DeleteUser)

# Arquitectura  
1)	WebApi, esta es la capa de la presentación 
2)	Persistence, esta es la capa de acceso a datos 
3)	Domain, esta es la capa encargada de la lógica de negocio
4)	Infrastructure, esta es la capa transversal de la aplicación para transportar los datos del moelo
5)	Config, en esta capa  se encuentra una clase container en la cual se registran las configuraciones del startup
6)	Unitest, esta es la capa para as pruebas unitarias 

# Descripción 
El primer endpoint que se debe ejecutar es el login en la cual se envía el usuario y la clave y este devuelve un token con el rol del usuario, este token se debe enviar en los headers de las demás peticiones para validar los permisos en la Api
