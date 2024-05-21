#include <iostream>
#include <iomanip>
using namespace std;

// Funktion zur Berechnung des Rabattsatzes basierend auf der Kategorie
double berechneRabatt(int kategorie) {
    switch (kategorie) {
    case 1: return 0.10;
    case 2: return 0.12;
    case 3: return 0.15;
    case 4: return 0.20;
    case 5: return 0.30;
    default: return 0.0;
    }
}

int main() {
    int anzahlProdukte;
    double einzelpreis;
    int kategorie;

    // Eingabedaten vom Benutzer abfragen
    cout << "Geben Sie die Anzahl der Produkte ein: ";
    cin >> anzahlProdukte;
    cout << "Geben Sie den Einzelpreis des Produktes ein: ";
    cin >> einzelpreis;
    cout << "Geben Sie die Kategorie des Kunden ein: ";
    cin >> kategorie;

    // Berechnung des Warenwerts ohne Rabatt
    double warenwertOhneRabatt = anzahlProdukte * einzelpreis;

    // Berechnung des Rabatts
    double rabattProzent = berechneRabatt(kategorie);
    double rabattInEuro = warenwertOhneRabatt * rabattProzent;

    // Berechnung des Nettowarenwertes (ohne Mehrwertsteuer)
    double nettoWarenwert = warenwertOhneRabatt - rabattInEuro;

    // Berechnung der Mehrwertsteuer (19%)
    double mehrwertsteuer = nettoWarenwert * 0.19;

    // Berechnung des Bruttowarenwertes (mit Mehrwertsteuer)
    double bruttoWarenwert = nettoWarenwert + mehrwertsteuer;

    // Ausgabe der Ergebnisse mit zwei Dezimalstellen
    cout << fixed << setprecision(2);
    cout << "Warenwert ohne Rabatt: " << warenwertOhneRabatt << " Euro" << endl;
    cout << "Rabatt in Euro: " << rabattInEuro << " Euro" << endl;
    cout << "Netto-Warenwert: " << nettoWarenwert << " Euro" << endl;
    cout << "Mehrwertsteuer: " << mehrwertsteuer << " Euro" << endl;
    cout << "Bruttowarenwert: " << bruttoWarenwert << " Euro" << endl;

    return 0;
}
