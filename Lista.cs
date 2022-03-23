using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1aQuestaoP2
{
    class Lista
    {
        //atributos
        Contato INICIO;
        Contato FIM;

        //metodos
        public Lista() {
            INICIO = null;
            FIM = null;
        }
        public bool estaVazia() {
            if (INICIO == null && FIM == null) {
                return true;
                
            }
            else {
                return false;
            }
        }

        public Contato buscar(int codigo) {
            //antes disso le o valor da text box e bota na variavel codigo que eh passada pra funcao
            Contato foundContato = INICIO;
            while (foundContato != null) {
                if (foundContato.getCodigo() == codigo){
                    
                }
                else {
                    foundContato = foundContato.getNext();
                }
            }
            return foundContato;
        }
        public void Remove(String nome) {
            Contato foundContato = INICIO;
            while (foundContato != null) {
                if (foundContato.getNome() == nome) {
                    if (foundContato == INICIO) {
                        INICIO = INICIO.getNext();
                        INICIO.setPrevio(null);
                    }
                    else if (foundContato == FIM) {
                        FIM = FIM.getPrevio();
                        FIM.setNext(null);
                    }
                    else {
                        (foundContato.getPrevio()).setNext(foundContato.getNext());
                        (foundContato.getNext()).setPrevio(foundContato.getPrevio());
                    }
                }
                else {
                    foundContato = foundContato.getNext();
                }
            }
        }

        public void ImprimeDireitaEsq() {
            if (estaVazia()) {
                Console.WriteLine("Lista vazia");
            }
            else {
                Contato temp = FIM;
                while (temp != null) {
                    System.Windows.Forms.MessageBox.Show(temp.getData() + " ");
                    temp = temp.getPrevio();
                }
            }
        }
        public void Insere(int codigo, String nome, String telefone, String email, String celular) {
            Contato newContato = new Contato();
            newContato.setCodigo(codigo);
            newContato.setNome(nome);
            newContato.setTel(telefone);
            newContato.setEmail(email);
            newContato.setCel(celular);
            //newContato.setData(dataaniv);

            if (estaVazia()) {
                INICIO = newContato;
                FIM = newContato;
            }
            else {
                FIM.setNext(newContato);
                newContato.setPrevio(FIM);
                FIM = newContato;
            }
        }

    }
}
