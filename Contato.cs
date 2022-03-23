using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1aQuestaoP2
{
    class Contato
    {
        //atributos
        private Contato previo;
        private Contato next;
        private int codigo;
        private String nome;
        private String telefone;
        private String celular;
        private String email;
        private Data1 dataAniversario;

        //metodos
        public Contato() { //construtor
            previo = null;
            next = null;
            codigo = 0;
            nome = null;
            telefone = null;
            celular = null;
            email = null;
            dataAniversario = null;
        }
        //GETTERS AND SETTERS
        public Contato getPrevio() {
            return previo;
        }
        public void setPrevio(Contato _previo) {
            previo = _previo;
        }
        public int getCodigo() {
            return codigo;
        }
        public void setCodigo(int _code) {
            codigo = _code;
        }
        public Contato getNext() {
            return next;
        }
        public void setNext(Contato _next) {
            next = _next;
        }
        public String getNome() {
            return nome;
        }
        public void setNome(String _nome) {
            nome = _nome;
        }
        public String getTel() {
            return telefone;
        }
        public void setTel(String _tel) {
            telefone = _tel;
        }
        public String getCel() {
            return celular;
        }
        public void setCel(String _cel) {
            celular = _cel;
        }
        public String getEmail() {
            return email;
        }
        public void setEmail(String _email) {
            email = _email;
        }
        public Data1 getData() {
            return dataAniversario;
        }
        public void setData(Data1 _dataAniversario) {
            dataAniversario = _dataAniversario;
        }

    }
}
