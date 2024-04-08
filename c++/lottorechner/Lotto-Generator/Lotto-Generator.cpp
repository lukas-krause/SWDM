#include "Lotto-Generator.h"
#include <iostream>
#include <intrin.h>
#include <cstdint>
#include <iomanip>

using namespace std;

bool get_random_number(unsigned short& randomValue) {
    return _rdrand16_step(&randomValue);
}

unsigned int generate_random_in_range(unsigned int min, unsigned int max) {
    unsigned int range = max - min + 1;
    unsigned short randNum;
    unsigned int scaledRandNum;

    do {
        if (!get_random_number(randNum)) {
            std::cerr << "Failed to generate a hardware random number (Your PC is trash)" << std::endl;
            return 0;
        }

        if (randNum < UINT16_MAX - (UINT16_MAX % range)) {
            scaledRandNum = min + (randNum % range);
        }
    } while (scaledRandNum < min || scaledRandNum > max);

    return scaledRandNum;
}

bool is_number_in_array(unsigned int arr[], int n, unsigned int number) {
    for (int i = 0; i < n; ++i) {
        if (arr[i] == number) {
            return true;
        }
    }
    return false;
}

void bubbleSort(unsigned int arr[], int n) {
    bool swapped;
    for (int i = 0; i < n - 1; i++) {
        swapped = false;
        for (int j = 0; j < n - i - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                unsigned int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;

                swapped = true;
            }
        }
        if (!swapped)
            break;
    }
}

int main() {
    char widerholen;

    do {
        unsigned int numbers[12][6];

        for (int j = 0; j < 12; ++j) {
            unsigned int currentSet[6] = { 0 };
            int currentSetSize = 0;
            for (int i = 0; i < 6; ) {
                unsigned int num = generate_random_in_range(1, 49);

                if (!is_number_in_array(currentSet, currentSetSize, num)) {
                    currentSet[currentSetSize++] = num;
                    numbers[j][i] = num;
                    i++;
                }
            }
            bubbleSort(numbers[j], 6);
        }

        std::cout << "Lottozahlen:\n";
        std::cout << "-----------------------\n";

        for (int j = 0; j < 12; ++j) {
            for (int i = 0; i < 6; ++i) {
                std::cout << std::setw(3) << numbers[j][i] << " ";
            }
            std::cout << std::endl;
        }

        std::cout << "Neue Zahlen generieren? (J/N): ";
        std::cin >> widerholen;
    } while (widerholen == 'J' || widerholen == 'j');

    return 0;
}

