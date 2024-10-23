function validacao(){

    nome = document.getElementById("nome").innerHTML;
    idade = document.getElementById("idade").innerHTML;
    peso = document.getElementById("peso").innerHTML;
    altura = document.getElementById("altura").innerHTML;
    
    document.write("Seu nome é "+nome+"\nSua idade é "+idade+"\nSeu peso é de "+peso+" KG\nSua altura é de "+altura+" M");
}

window.onload = function(){
    const botao = document.getElementById("bt");
    botao.addEventListener("click", validacao);
};