const articles = [];

      class Article {
        constructor(ref, marque, prix) {
          this.ref = ref;
          this.marque = marque.toUpperCase();
          this.prix = parseFloat(prix).toFixed(2) + " €";
        }
      }

      window.onload = () => {
        const refInput = document.getElementById("ref");
        const marqueInput = document.getElementById("marque");
        const prixInput = document.getElementById("prix");
        const ajouterBtn = document.getElementById("btn-ajouter");
        const afficherBtn = document.getElementById("btn-afficher");
        const tbody = document.getElementById("articlesTable").querySelector("tbody");

        ajouterBtn.addEventListener("click", () => {
          const ref = refInput.value.trim();
          const marque = marqueInput.value.trim();
          const prix = prixInput.value;

          if (!ref || !marque || !prix) {
            alert("Veuillez remplir tous les champs !");
            return;
          }

          articles.push(new Article(ref, marque, prix));

          // reset
          refInput.value = "";
          marqueInput.value = "";
          prixInput.value = "";
        });

        afficherBtn.addEventListener("click", () => {
          tbody.innerHTML = "";
          articles.forEach((article) => {
            const row = document.createElement("tr");
            row.innerHTML = `
              <td>${article.ref}</td>
              <td>${article.marque}</td>
              <td>${article.prix}</td>
            `;
            tbody.appendChild(row);
          });
        });
      };