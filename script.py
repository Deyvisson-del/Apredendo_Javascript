nome = str(input("Digite o sue nome: "))
print("Boas vindas",nome)

pokemon = ["pikachu", "charmander", "Bulbasaur"]

pokemon.pop()   # Remove o último elemento
pokemon.pop(0)  # Remove o primeiro elemento

print(pokemon)  # Exibe o array resultante