# prueba_tecnica_net

# Soy Mario Valle y esta es una prueba que me han pedido en la que :

# Realizar un programa en .Net - C# 
# 1. Crear: clase, función que consuma la siguiente API. puede escoger cualquier servicio.
# - https://api.opendata.esett.com/
# 2. Almacenar esta inforamción en la base de datos
# 3. realizar un controlador que filter por Primary Key
# 4. Construir una api Rest con swagger que permita visualizar los datos almacenados en la base de datos.

# # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # Prueba

# Para ello hemos creado nuestro proyecto de API Web ASP.NET Core, y le hemos llamado prueba_tecnica_net
# Hemos creado la base de datos y puesto el conecction para que nos permita tenerlo linkeado y, en este caso
# guardar los datos que recibamos de nuestra API tambien en BBDD.
# hemos instalado desde nuget sql, tools, y Swashbuckle que sera necesario para el swagger.
# en el program.cs hemos eliminado el caso de prueba que nos realiza directamente el proyecto de inicio para referenciarlo a nuestro swagger.
# He ido organizando el proyecto para tenerlo organizado en carpetas, de controladores, mmodelos, servicios, etc
# Hemos creado nuestra clase de modelo EsettData, para tener el Id(nuestra PK) y el Data que seran los datos que obtendremos de la API
# Por consiguiente nuestro AppDbContext para gestionar las conexiones de la BBDD.
# Y el servicio EsettService en el que consumiremos la informacion de la API y un condicional para poner error en el caso que no se haya podido consumir.
# Luego nuestro controlador EsettController que se encargara de exponer los endpoints de la API para sincronizar los datos de la API de Esett con la base de datos
# y consultar los datos almacenados.

# Ejecutaremos en nuestra consola(zona parte de nuget) el siguiente comando : Add-Migration InitialCreate para que nos cree las tablas necesarias, y:  Update-Database para actualizarla

# Por consiguiente al ejecutar nuestra app, nos mostrara los dos procedimientos realizados, uno para sincronizar los datos desde la API de Esett y guardarlos en la base de datos(/api/esett/sync-data:).

# y otro para consultar los datos almacenados por primary key  (/api/esett/{id}).


# Con esto estaria resuelto el ejercicio,


# P.D: cabe destacar que para evitar incongruencias por el lenguaje y fiabilidad de AOT se ha comentado y puesto en false el tema idiomas ,
# y que teneis que cambiar el nombre del servidor y de vuestra BBDD antes de probar

#     <InvariantGlobalization>false</InvariantGlobalization>
#     <!--<PublishAot>true</PublishAot>-->


# Un saludo, Mario Valle.