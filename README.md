# NewOverrideExercice

La diferencia entre overload y override es es que se sobreescriben los metodos iguales pero overload utiliza diferentes parametros.
En la clase base se tiene que crear un metodo virtual y luego en la clase heredada se utiliza override.
Con el sealed no se puede utilizar mas el override.
Cada vez que se utiliza virutal en una clase base en la heredada no se puede utilizar New, este oculta el metodo ejecutado por la clase heredada y muestra el de la clase base. 
Por lo que utilizar new seria un indicador para que el compilador no piense que estamos cometiendo un error si nombramos un miembro de una clase como uno de los que contenga su clase base.
