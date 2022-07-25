using SistemaEscola.Enum;
using SistemaEscola.Model;
using SistemaEscola.Models;
using SistemaEscola.Utils;
using SistemaEscola.View;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace SistemaEscola.ViewModel
{
    public class MainViewModel : Observe
    {

        public ObservableCollection<IPessoa> listaPessoas{ get; set; }
        public ICommand CadastroPessoa { get; set; }

        public IPessoa PessoaSelecionada { get; set; }
        public ICommand RemoverPessoa { get; set; }
        public ICommand AtualizarPessoa { get; set; }

        public string PessoaAdicionar
        {
            get;
            set;
           
        }
        public MainViewModel()
        {
            listaPessoas = new ObservableCollection<IPessoa>()
             {
                        new Aluno()
                        {
                            Nome = "Sérgio ",
                            Sobrenome= "Damaceno Botelho",
                            Matricula = 20220725,
                            Serie = "PrimeiraSerie",
                        },
                        new Funcionario()
                        {
                            Nome = "Danielle",
                            Sobrenome = "Yasmin Caovilla ",
                            Cargo = "Professora",
                            Salario = 2500,
                            CodFuncionario = 20220726,
                        }

            };
            
            CadastroPessoa = new RelayCommand((_) =>
            {
                if (PessoaAdicionar != "Todos")
                {
                    IPessoa elemento = NovaPessoa.criaNovaPessoa(PessoaAdicionar);
                    Window tela = NovaPessoa.criaNovaTela(PessoaAdicionar);
                    tela.DataContext = elemento;
                    tela.ShowDialog();
                    if (tela.DialogResult == true)
                    {

                        listaPessoas.Add(elemento);

                    }

                }
                
            
            });


            RemoverPessoa = new RelayCommand((_) =>
            {
                if (PessoaSelecionada != null)
                {
                    listaPessoas.Remove(PessoaSelecionada);
                }
            });

            AtualizarPessoa = new RelayCommand((_) =>
            {

                if (PessoaSelecionada != null)
                {
                    Aluno aluno = PessoaSelecionada as Aluno;
                    Funcionario funcionario = PessoaSelecionada as Funcionario;

                    if (aluno != null)
                    {

                        Aluno nova = (Aluno)aluno.Clone();
                        FormularioAluno form = new FormularioAluno();
                        form.DataContext = nova;
                        form.ShowDialog();
                        if (form.DialogResult == true)
                        {
                            aluno.Nome = nova.Nome;
                            aluno.Sobrenome = nova.Sobrenome;
                            aluno.Matricula = nova.Matricula;
                            aluno.Serie = nova.Serie;

                        }
                    }

                    if (funcionario != null)
                    {
                        Funcionario nova = (Funcionario)funcionario.Clone();
                        FormularioFuncionario form = new FormularioFuncionario();
                        form.DataContext = nova;
                        form.ShowDialog();
                        if (form.DialogResult == true)
                        {
                            funcionario.Nome = nova.Nome;
                            funcionario.Sobrenome = nova.Sobrenome;
                            funcionario.Salario = nova.Salario;
                            funcionario.Cargo = nova.Cargo;
                        }
                    }

                }
            });
        }

    }
}