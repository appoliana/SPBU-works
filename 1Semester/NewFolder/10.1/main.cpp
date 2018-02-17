#include <cstdlib>
#include <fstream>
#include <iostream>
#include <vector>

using namespace std;

bool thereAreUncheckedTowns(const vector<int>& towns) {
    for (int town : towns) {
        if (town == -1) {
            return true;
        }
    }
    return false;
}

void printResult(int numberOfCountries, int[] towns);

void searchOfTheAnswer(towns, currentCountry, edges);

void printDates(edges);

struct Edge {
    const int first;
    const int second;
    const int length;
    explicit Edge(int first, int second, int length)
        : first(first)
        , second(second)
        , length(length) {
    }
};

int main(int argc, char** argv) {
    ifstream input("file.txt");
    int numberOfTowns = 0;
    int numberOfRoads = 0;
    input >> numberOfTowns >> numberOfRoads;
    vector<vector<Edge>> edges(numberOfTowns);
    for (int i = 0; i < numberOfRoads; ++i) {
        int first = 0;
        int second = 0;
        int length = 0;
        input >> first >> second >> length;
        edges[first].push_back(Edge(first, second, length));
        edges[second].push_back(Edge(second, first, length));
    }

    int numberOfCountries = 0;
    input >> numberOfCountries;
    vector<int> towns(numberOfTowns, -1); // -1 is for no country
    for (int i = 0; i < numberOfCountries; ++i) {
        int country;
        input >> country;
        towns[country] = i;
    }
    input.close();

    printDates(edges);

    searchOfTheAnswer(towns, currentCountry, edges);

    printResult(numberOfCountries, towns);

    return 0;
}

void printDates(int[] &edges)
{
    for (int townIndex = 0; townIndex < edges.size(); ++townIndex) {
        cout << "Town " << townIndex << ":";
        for (int edgeIndex = 0; edgeIndex < edges[townIndex].size(); ++edgeIndex) {
            const Edge& edge = edges[townIndex][edgeIndex];
            cout << " (" << edge.second << ", " << edge.length << ")";
        }
        cout << ";" << endl;
    }

    cout << endl;
}

void searchOfTheAnswer(int[] &towns, int &currentCountry, int[] &edges)
{
    int currentCountry = 0;
    while (thereAreUncheckedTowns(towns)) {
        for (int townIndex = 0; townIndex < towns.size(); ++townIndex) {
            cout << " " << towns[townIndex];
        }
        cout << endl;
        int nearestNewTown = -1;
        int minLength = -1;
        for (int townIndex = 0; townIndex < towns.size(); ++townIndex) {
            if (towns[townIndex] == currentCountry) {
                for (int edgeIndex = 0; edgeIndex < edges[townIndex].size(); ++edgeIndex) {
                    const Edge& edge = edges[townIndex][edgeIndex];
                    int secondTown = edge.second;
                    if (towns[secondTown] == -1) {
                        int length = edge.length;
                        if ((minLength == -1) || length < minLength {
                            minLength = length;
                            nearestNewTown = secondTown;
                        }
                    }
                }
            }
        }
        if (nearestNewTown != -1) {
            towns[nearestNewTown] = currentCountry;
        }
        currentCountry = (currentCountry + 1) % numberOfCountries;
    }
}

void printResult(int numberOfCountries, int[] towns)
{
    cout << endl;
    cout << "Results:" << endl;
    for (int countryIndex = 0; countryIndex < numberOfCountries; ++countryIndex) {
        cout << " Number of country: " << countryIndex << ". Towns list: ";
        for (int townIndex = 0; townIndex < towns.size(); ++townIndex) {
            if (towns[townIndex] == countryIndex) {
                cout << " " << townIndex;
            }
        }
        cout << endl;
    }
}








