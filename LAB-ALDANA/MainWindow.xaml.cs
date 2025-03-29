using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LAB_ALDANA
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Profesor> profesores = new List<Profesor>();
            profesores.Add(new Profesor { Apellidos = "Gomez", Nombres = "jaime" });
            profesores.Add(new Profesor { Apellidos = "Torrico", Nombres = "Hugo" });

            dgProfesores.ItemsSource = profesores;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<Curso> cursos = new List<Curso>();
            cursos.Add(new Curso { Nombre = "Matemática", Alumno = "Jhersin" ,Notas= 18});

            dgCursos.ItemsSource = cursos;
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            

            dgProfesores.ItemsSource = null;
        }
    }
}
