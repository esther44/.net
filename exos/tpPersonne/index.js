document.getElementById("btn").addEventListener("click", function(){
    const nom = document.getElementById("nom").value.trim();
    const prenom = document.getElementById("prenom").value.trim();
    const age = parseInt(document.getElementById("age").value, 10);

    const personne = {
        nom,
        prenom,
        age,
        getInfo(){
            const status = this.age >= 18 ? "majeur" : "mineur";
            return this.nom.toUpperCase() + "\n"+
             this.prenom.toLowerCase() + "\n"+ 
             this.age+ "\n"+ 
             status
        }
    }
    document.getElementById("resultat").textContent = personne.getInfo();
})