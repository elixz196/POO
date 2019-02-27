# 2.1 Declaración de clases: atributos, métodos, encapsulamiento.

##  Lee y escribe un resumen con tus palabras del siguiente documento:

Las clases son de las construcciones basicas de common type system en .NET Framework. Cada una viene siendo una estructura que forman un conjunto. Los datos, y comportamientos, tambien incluyen metodos, propiedades y eventos. 

Una declaracion de clase es como un plano que se utiliza para crear instancias y objetos. Si definimos una clase llamada "Persona", "Persona" es el nombre del tipo de clase y si se declara una variable "p" por ejemplo de tipo "Persona" entonces decimos que "p" es un objeto de la clase "persona", se pueden crear muchas variables tipo "Persona" y cada instancia diferentes valores en sus propiedades y campos.
Una clase es un tipo de referencia. Cuando se crea un objeto de la clase, la variable a la que se asigna el objeto solo tiene una referencia a esa memoria. 

Una estructura es un tipo de valor. Cuando se crea una estructura, la variable a la que se asigna la estructura contiene todos los datos reales de ella. cuando la estructura se le asigna una nueva variable se copia, y las dos variables tienen dos copias independientes de los mismos datos por lo que los cambios que se hagan en una variable no afectan a la otra copia.

para concluir, las clases se utilizan para modelar comportamientos mas complejos, o datos que se preveen modificar despues de haber creado un objeto de clase. y las estructuras se utilizan para estructuras de datos peque;as que contienen datos que no se piensan modificar mas adelante.

=================================================================

 # 2.2 Instanciación de una clase.
 ## Investiga sobre el operador new visto en clase. Describe algunos de sus usos.
 
 **Se utiliza para crear objetos e invocar constructores:**

 _Class1 obj  = new Class1();_

 **tambien se utiliza para hacer instancias de tipo anonimos:**

 _var query = from cust in customers
            select new { Name = cust.Name, Address = cust.PrimaryAddress };_

==========================================================
# 2.3 Referencia al objeto actual.  
##   La palabra clave this hace referencia a la instancia actual de la clase. 

Escribe un programa donde utilices this para obtener acceso a miembros con el fin de evitar ambigüedades con nombres similares.
Escribe un programa donde se utilice this como parámetro.

class Persona

{

    protected string nombre;
    protected int edad;

    public Persona(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }
}

=================================================================
#  2.4 Métodos: declaración, mensajes, paso de parámetros, retorno de valores.
## Lee y escribe un resumen con tus palabras de los siguientes documentos: 

### 1. Parámetros de métodos (Referencia de C#):

los parametros que no estan declarados en in, out o ref pasan a ser llamados metodo por valor, el valor se puede cambiar en el metodo, pero se va a perder cuando el metodo retome el control al procedimiento que realizo la llamada

Esta sección describe las palabras clave que puede usar para declarar parámetros de métodos:

1. params especifica que este parámetro puede tomar un número variable de argumentos.
2. in especifica que este parámetro se pasa por referencia, pero solo se lee mediante el método llamado.
3. ref especifica que este parámetro se pasa por referencia y puede ser leído o escrito por el método llamado.
4. out especifica que este parámetro se pasa por referencia y se escribe mediante el método llamado.

### 2. params (Referencia de C#):

Params puede enviar una lista de argumentos separados por coma definidos previamente cada uno con su tipo, tambien puede no enviar nada, entonces valdria 0.

### 3. out (Referencia de C#):

Como un modificador de parámetro, que le permite pasar un argumento a un método mediante una referencia en lugar de mediante un valor. lo cual significa que el argumento se manda a a travez de un hipervinculo en pocas palabras en lugar de modificar el argumento con valores directos.

### 4. ref (Referencia de C#):

la palabra clave _ref_ indica un valor que se ha pasado mediante referencia. Se usa en cuatro contextos diferentes:

1. En una firma del metodo y en una llamada al metodo, para pasar un argumento a un metodo mediante referencia.
2. para devolver un valor al autor de la llamada por medio de la referencia.
3. En un cuerpo de miembro, para indicar el valor devuelto de referencia se almacena localmente como una referencia que el autor de la llamada pretende modificar.
4. En una declaracion struct para declarar ref struct o ref readonly struct

ref se utiliza para pasar un argumento como referencia, como su nombre lo dice practicamente, no por valor. el efecto de pasar algo como referencia es que cualuqier cambio del argumento en el metodo llamado se refleja en el metodo de llamada.

=================================================================

#  2.5 Constructores y destructores: declaración, uso y aplicaciones.

##   Lee y escribe un resumen con tus palabras del siguiente documento:

### Constructores:
los constructores son metodos que los objetos utilizan para cada vez que se crea un objeto para inicializarlo y lo que hace es que verifique que el objeto tenga valores valido, se llaman de la misma manera que la clase

### Destructores
Basicamente hace lo contrario a un constructor, cuando un objeto es destruido, limpia los residuos de este.

=================================================================

# 2.6 Sobrecarga de métodos. 
## Ver el ejercicio siguiente...

=================================================================
# 2.7 Sobrecarga de operadores: Concepto y utilidad, operadores unarios y binarios.
## Implementa una clase llamada Dado, la cual es una abstracción de los dados de algún juego.

### Debe de tener por lo menos las siguientes propiedades:

1. valor
2. color

### La clase debe contar por lo menos con:

      Dos constructores sobrecargados.

      Los operadores ==, <, > sobrecargados.

      El uso de la palabra clave this.

   

    Utiliza tu clase dentro del método Main de tu programa, creando tres dados, arrojándolos e imprimiendo el mejor de ellos 

    o si alguno es igual.

    


