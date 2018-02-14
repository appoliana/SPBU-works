#include <cstdlib>
#include <fstream>
#include <iostream>
#include <vector>

using namespace std;

bool thereAreUncheckedTowns(const vector<int>& towns) {
    for (int townIndex = 0; townIndex < towns.size(); ++townIndex) {
        if (towns[townIndex] == -1) {
            return true;
        }
    }
    return false;
}

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
    vector<vector<Edge> > edges(numberOfTowns);
    for (int i = 0; i < numberOfRoads; ++i) {
        int first;
        int second;
        int length;
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
        towns[country] = static_cast<int>(i);
    }
    input.close();

    for (int townIndex = 0; townIndex < edges.size(); ++townIndex) {
        cout << "Town " << townIndex << ":";
        for (int edgeIndex = 0; edgeIndex < edges[townIndex].size(); ++edgeIndex) {
            const Edge& edge = edges[townIndex][edgeIndex];
            cout << " (" << edge.second << ", " << edge.length << ")";
        }
        cout << ";" << endl;
    }

    cout << endl;

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
                        if ((minLength == -1) || length < static_cast<int>(minLength)) {
                            minLength = static_cast<int>(length);
                            nearestNewTown = static_cast<int>(secondTown);
                        } 
                    } 
                }
            }
        }
        if (nearestNewTown != -1) { 
            towns[static_cast<int>(nearestNewTown)] = currentCountry;
        } 
        currentCountry = (currentCountry + 1) % numberOfCountries;
    }

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
    return 0;
}