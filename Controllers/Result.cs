namespace VaquesBackend.Controllers {
    public class Result {
        public string resultat;

        public Result() {}

        public Result(string missatge) {
            resultat = missatge;
        }
        public string getResultat() {
            return resultat;
        }

        public void setResultat(string resultat) {
            this.resultat = resultat;
        }
    }
}