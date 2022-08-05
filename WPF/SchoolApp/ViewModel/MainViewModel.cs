using SchoolApp.Utils;
using SistemaEscola.Enum;
using SistemaEscola.Model;
using SistemaEscola.Models;
using SistemaEscola.Utils;
using SistemaEscola.View;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using MessageBox = System.Windows.Forms.MessageBox;

namespace SistemaEscola.ViewModel
{
    public class MainViewModel : Observe
    {
        public ObservableCollection<IPessoa> listaPessoas
        {
            get;
            set;
        }
        public PostgreSql Banco = new PostgreSql();

        public ICommand CadastroPessoa { get; set; }
        
        public IPessoa PessoaSelecionada { get; set; }
        public ICommand RemoverPessoa { get; set; }
        public ICommand AtualizarPessoa { get; set; }
        private AdicionarPessoas pessoaAdicionar { get; set; } = AdicionarPessoas.Todos;
        public AdicionarPessoas PessoaAdicionar
        { 
            get
            {

                return pessoaAdicionar;
            }
            set
            {
                pessoaAdicionar = value;
                Ativado();

            }
        }
        public bool Desativado { get; set; }
        
        public void Ativado()
        {
            if (PessoaAdicionar == (int)AdicionarPessoas.Todos)
            {
                Desativado = false;
                Notifica("Desativado");
            }
            else
            {
                Desativado = true;
                Notifica("Desativado");
            }
        }
    
        public MainViewModel()
        {
            Banco.Testarconexao();
            
            try
            {
                listaPessoas = new ObservableCollection<IPessoa>(Banco.Carregar());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Carregar a lista de Alunos/Funcionarios: {ex.Message}", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
            IniciaComandos();
            Conexao conn = new Conexao(new PostgreSql());
        }
        public void IniciaComandos()
        {
            CadastroPessoa = new RelayCommand((_) =>
            {
                if (PessoaAdicionar != (int)AdicionarPessoas.Todos)
                {
                    IPessoa pessoa = NovaPessoa.criaNovaPessoa(PessoaAdicionar);
                    Window tela = NovaPessoa.criaNovaTela(PessoaAdicionar);
                    tela.DataContext = pessoa;
                    tela.ShowDialog();
                    if (tela.DialogResult == true)
                    {
                        try
                        {
                            Banco.Inserir(pessoa as Pessoa);
                            listaPessoas.Add(pessoa);

                        }
                        catch
                        {
                            MessageBox.Show($"Erro ao inserir Alunos/Funcionarios", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }

            });


            RemoverPessoa = new RelayCommand((_) =>
            {
                if (PessoaSelecionada != null)
                {
                    try {
                       Banco.Remover(PessoaSelecionada as Pessoa);
                       listaPessoas.Remove(PessoaSelecionada);

                    }
                    catch {
                        MessageBox.Show("Erro ao Remover Alunos/Funcionarios", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    
                        
                    

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

                        Aluno clone = (Aluno)aluno.Clone();
                        FormularioAluno form = new FormularioAluno();
                        form.DataContext = clone;
                        form.ShowDialog();
                        if (form.DialogResult == true)
                        {
                            try
                            {
                                Banco.EditarAluno(PessoaSelecionada as Aluno, clone);
                                aluno.Nome = clone.Nome;
                                aluno.Sobrenome = clone.Sobrenome;
                                aluno.Matricula = clone.Matricula;
                                aluno.Serie = clone.Serie;
                                MessageBox.Show("Sucesso ao Editar Aluno", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                

                            }
                            catch
                            {
                                MessageBox.Show("Erro ao Editar Aluno, Matricula já existente!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                          

                        }
                    }
                    if (funcionario != null)
                    {
                        Funcionario clone = (Funcionario)funcionario.Clone();
                        FormularioFuncionario form = new FormularioFuncionario();
                        form.DataContext = clone;
                        form.ShowDialog();
                        if (form.DialogResult == true)
                        {
                            try
                            {
                                Banco.EditarFuncionario(PessoaSelecionada as Funcionario, clone);
                                funcionario.Nome = clone.Nome;
                                funcionario.Sobrenome = clone.Sobrenome;
                                funcionario.Salario = clone.Salario;
                                funcionario.Cargo = clone.Cargo;
                                funcionario.CodFuncionario = clone.CodFuncionario;
                                MessageBox.Show("Sucesso ao Editar Funcionario", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                               
                            catch
                            {
                                MessageBox.Show("Erro ao Editar Funcionario, CodFuncionario já existente!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                }
            });
        }
    }
}