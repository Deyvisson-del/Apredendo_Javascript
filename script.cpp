#include <iostream>
#include <vector>
#include <string>

int main() {
    std::vector<std::string> pokemon = {"pikachu", "charmander", "Bulbasaur"};
    
    pokemon.pop_back();  // Remove o último elemento
    pokemon.erase(pokemon.begin());  // Remove o primeiro elemento
    
    for (const auto& p : pokemon) {
        std::cout << p << " ";  // Exibe o array resultante
    }

    return 0;
}
