# PruebaFinaktiva
Repositorio para prueba back-end Finaktiva

# Desarrollo 
Este prueba fue desarrolalda en Netcore 3.1 y SQL Server 2019, utilizando el JWT Authentication para el envio de token

# Instalación
1) Crear la bd PruebaFinaktiva y ejecutar el script que se encuentra en la  carpeta bd , en esta se encuentra el script para la craacion de las tablas
2) cambiar el ConnectionStrings dentro del archivo appsettings.json del proyecto PruebaFinaktiva
3) abrir con postman el archivo que se encuentra en la carpeta collection, el cual contiene las peticiones de la Api (Login,getUser,CreateUser,UpdateUser, DeleteUser)

# Arquitectura  
Para esta prueba se crearon 6 capas:
1)	WebApi, esta es la capa de la presentación en la cual 
2)	Persistence, esta es la capa de acceso a datos 
3)	Domain, esta es la capa encargada del Modelo de negocio
4)	Infrastructure, esta es la campa transversal de modelos
5)	Config, esta es la capa de configuraciones especiales para la aplicación 
6)	Unitest, esta es la capa para as pruebas unitarias 


# Descripcion 
la peticion inicial es la de login en la cual se envia el usuario y la clave y este devuelve un token con el rol del usario, este token se debe enviar en los headers de las demas peticiones  para validar  los permisos de la Api

