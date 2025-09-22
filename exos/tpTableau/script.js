const personnes = [];

document.addEventListener("DOMContentLoaded", ()=>{
    const btnAdd = document.getElementById("btnAdd");
    const btnPrint = document.getElementById("btnPrint");

    btnAdd.addEventListener("click", ajouterPersonne);
    btnPrint.addEventListener("click", afficherListe);
});

function ajouterPersonne() {
  const nom = document.getElementById("nom").value.trim();
  const prenom = document.getElementById("prenom").value.trim();

  if (nom === "" || prenom === "") {
    alert("Veuillez saisir un nom et un prénom !");
    return;
  }

  personnes.push({ nom, prenom });

  document.getElementById("nom").value = "";
  document.getElementById("prenom").value = "";
}

function afficherListe() {
  const ul = document.getElementById("liste");
  ul.innerHTML = "";

  personnes.forEach((p) => {
    const li = document.createElement("li");
    li.textContent = `${p.nom.toUpperCase()} ${p.prenom}`;
    ul.appendChild(li);
  });
}