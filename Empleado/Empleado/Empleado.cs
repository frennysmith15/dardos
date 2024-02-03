// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Persona persona = new Persona("Juanito Villamontes", 33);

Empleado empleado = new Empleado(persona, 31000.50);

persona.mostrar();
empleado.mostrar();
empleado.mostrarSalario();

class Persona
{
    private string nombre;
    private int edad;

    public Persona( string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;   
    }

    public string getNombre() { return nombre; }
    public void setNombre(string nombre) {  this.nombre = nombre; }
    public int getEdad() {  return edad; }
    public void setEdad(int edad) { this.edad = edad; }

    public void mostrar()
    {
        Console.WriteLine(nombre + " " + edad);
    }
    
}

class Empleado : Persona
{
    private double salario;

    public Empleado(string nombre, int edad, double salario) : base(nombre, edad)
    {
        this.salario = salario;
    }

    public Empleado(Persona persona, Double salario) : base(persona.getNombre(), persona.getEdad())
    {
        this.salario= salario;
    }

    public double getSalario() {  return salario; }
    public void setSalario(double salario) { this.salario = salario; }
    public void mostrarSalario() { Console.WriteLine(salario.ToString()); }


}