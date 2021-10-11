// Em um portal de cursos online, cada usuário possui um código único, representado por
// um número inteiro.
// Cada instrutor do portal pode ter vários cursos, sendo que um mesmo aluno pode se
// matricular em quantos cursos quiser. Assim, o número total de alunos de um instrutor não
// é simplesmente a soma dos alunos de todos os cursos que ele possui, pois pode haver
// alunos repetidos em mais de um curso.
// O instrutor Alex possui três cursos A, B e C, e deseja saber seu número total de alunos.
// Seu programa deve ler os alunos dos cursos A, B e C do instrutor Alex, depois mostrar a
// quantidade total e alunos dele, conforme exemplo.
using System;
using HashSetAndHashSortEx5.Entities;
using System.Collections.Generic;

namespace HashSetAndHashSortEx5
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> courseA = new HashSet<Student>();
            HashSet<Student> courseB = new HashSet<Student>();
            HashSet<Student> courseC = new HashSet<Student>();
            char[] CouseName = new char[3] {'A','B','C'};

            for(int i=0;i<3;i++){
                System.Console.Write("How many students for course " + CouseName[i] + "? ");
                int n = int.Parse(Console.ReadLine());
                for(int k=0;k<n;k++){
                    int id  = int.Parse(Console.ReadLine());
                    if(i==0){
                        courseA.Add(new Student(id));
                    }else if(i==1){
                        courseB.Add(new Student(id));
                    }else{
                        courseC.Add(new Student(id));
                    }
                }
            }
            HashSet<Student> dif = new HashSet<Student>(courseA);
            dif.UnionWith(courseB);
            dif.UnionWith(courseC);
            System.Console.WriteLine(dif.Count);
            
        }
    }
}
