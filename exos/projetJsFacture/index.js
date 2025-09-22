const factures = [];

      class Facture {
        constructor(selection, quantite, client, civilite) {
          this.selection = selection;
          this.quantite = parseInt(quantite);
          this.client = client;
          this.civilite = civilite;
        }

        getPrix(){
            switch(this.selection){
                case "coca": return Prix.COCA * this.quantite;
                case "fanta": return Prix.FANTA * this.quantite;
                case "perrier": return Prix.PERRIER * this.quantite;
                case "biere": return Prix.BIERE * this.quantite;
                default :return 0;
            }
        }
      }

      const Prix = {
      COCA: 2.5,
      FANTA: 2.0,
      PERRIER: 1.5,
      BIERE: 3.0
    };



      window.onload = () => {
        const selectionInput = document.getElementById("selection");
        const quantiteInput = document.getElementById("quantite");
        const clientInput = document.getElementById("client");
        const mrRadio = document.getElementById("mr");
        const mmeRadio = document.getElementById("mme");
        const detailCheck = document.getElementById("detail");
        const totalCheck = document.getElementById("total");
        const detailList = document.getElementById("detail-list");
        const totalBloc = document.getElementById("total-bloc");
        const okButton = document.getElementById("ok-button");

        okButton.addEventListener("click", () => {
          const selection = selectionInput.value;
          const quantite = quantiteInput.value;
          const client = clientInput.value.trim();
         const civilite = mrRadio.checked ? "Mr" : (mmeRadio.checked ? "Mme" : "");

          if (!selection || !quantite || !client || !civilite) {
            alert("Veuillez remplir tous les champs !");
            return;
          }

          factures.push(new Facture(selection, quantite, client, civilite));

          if (detailCheck.checked) {
            const dernier = factures[factures.length - 1];
            let prixUnitaire;
            switch (dernier.selection) {
              case "coca": prixUnitaire = Prix.COCA; break;
              case "fanta": prixUnitaire = Prix.FANTA; break;
              case "perrier": prixUnitaire = Prix.PERRIER; break;
              case "biere": prixUnitaire = Prix.BIERE; break;
            }
            const li = document.createElement("li");
            li.classList.add("list-group-item");
            li.textContent = `${dernier.selection} x ${dernier.quantite} = ${(prixUnitaire * dernier.quantite).toFixed(2)} €`;
            detailList.appendChild(li);
        }

        if (totalCheck.checked) {
          total = factures.reduce((acc, f) => acc + f.getPrix(), 0);
          totalBloc.innerHTML = `<div class="alert alert-info fw-bold">${civilite} ${client} - Total Facture : ${total.toFixed(2)} €</div>`;
        }
      });
    }