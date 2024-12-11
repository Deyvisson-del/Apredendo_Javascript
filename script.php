<?php
// Código em PHP
echo "Digite o seu nome: ";
$name = trim(fgets(STDIN));
echo "Bem-vindo: " . $name . PHP_EOL;

$pokemon = ["pikachu", "charmander", "Bulbasaur"];

array_pop($pokemon);  // Remove o último elemento
array_shift($pokemon); // Remove o primeiro elemento

print_r($pokemon); // Exibe o array resultante
?>
