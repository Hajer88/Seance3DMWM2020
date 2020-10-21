using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Seance3DMWM2020
{
    class Patient
    {
        public string Name  { get; set; }
        public int age { get; set; }
        public string Gender { get; set; }
        public virtual void Examiner()
        {
            Console.WriteLine("Le patient a été examiné");
        }
    }
    class Adult: Patient
    {
        public override void Examiner()
        {
            Console.WriteLine("L'adulte a été examiné");
        }
        public void Billing()
        {
            Console.WriteLine("Facturation Exécutée");
        }
    }
    class Child:Patient
    {
        public void TestChild()
        {
            Console.WriteLine("Test Child exécutée");
        }
    }
    class UnderFive : Child
    {

    }
    class Program
    {
        static void Main(string[] args)
        {

            //Test Boxing unboxing
            object o;
            int x = 25;
            o = x;//BOxing
            o = 123;
            x = (int)o;//Unboxing
            List<int> arrayList = new List<int>();
            arrayList.Add(5);
            arrayList.Add(6);
            arrayList.Add(10);
            //Erreur de compilation type générique
            //arrayList.Add("Hello");
            foreach (int i in arrayList)
            {
                Console.WriteLine(i);
            }
            test t = new test();
            t.FaireQQchose();
            ((IPremiereInterfac)t).FaireQQchose();
            Console.WriteLine("Hello World!");
            //Ecrire une classe générique 
            //contenant une méthode générique
            //d'addition de deux éléments
            GenericClass<int> gen = new GenericClass<int>();

            gen.Add(3);
            //public class MyGenericClass<T> where T:class
            //MyGenericClass<int> c = new MyGenericClass<int>(10);
            //MyGenericClass<Client> c = new MyGenericClass<Client>(new
            //Client())


            //Exercice1Atelier 4
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add("Un");
            arrayList1.Add("Deux");
            //arrayList1.AddRange();
            Console.WriteLine("Le nombre d'éléments est", arrayList1.Count);
            //Ajouter un nouvel élément
            arrayList1.Add("Trois");
            Console.WriteLine("Le nouveau nombre est", arrayList1.Count);
            foreach (var item in arrayList1)
            {
                Console.WriteLine("l'entree est", item);
            }

            //Exercice2 Atelier 4
            List<Point> listpoint = new List<Point> { new Point { x = 1,
            y=2},new Point{x=3,y=4} };
            foreach (var item in listpoint)
            {
                Console.WriteLine(item);
            }
            List<Rectangle> rect = new List<Rectangle>
            {
                new Rectangle{ TopLeft =new Point{x=5,y=7},
                ButtomRight = new Point {x=6,y=7}},
                new Rectangle{TopLeft =new Point{x=5,y=7},
                ButtomRight = new Point {x=7,y=8}}
            };
            //Exercice 3 Atelier 4
            List<Personne> personnes = new List<Personne>
            { new Personne { FirstName = "aaa", LastName="bbb",
            Age=55} };
            //Compter la liste des éléments
            Console.WriteLine(personnes.Count);
            foreach (var item in personnes)
            {
                Console.WriteLine(item);
            }
            //Insérer une nvlle personne
            personnes.Insert(2, new Personne {
                FirstName = "xxx",
                LastName = "ccc",
                Age = 55
            });
            Personne[] p= personnes.ToArray();


        }
    }
}
