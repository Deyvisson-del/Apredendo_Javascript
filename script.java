import java.util.ArrayList;
import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        ArrayList<String> pokemon = new ArrayList<>(Arrays.asList("pikachu", "charmander", "Bulbasaur"));
        
        pokemon.remove(pokemon.size() - 1); // Remove o último elemento
        pokemon.remove(0); // Remove o primeiro elemento
        
        System.out.println(pokemon); // Exibe o array resultante
    }
}
