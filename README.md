
# Planer Treningowy

## Temat i Cel Biznesowy
Aplikacja **Planer Treningowy** została stworzona w celu umożliwienia użytkownikom planowania, śledzenia i analizowania swoich treningów.  
Dzięki aplikacji użytkownik może łatwiej realizować swoje cele fitnessowe, monitorować postępy i dostosowywać plany treningowe do własnych potrzeb.  
Grupą docelową są osoby aktywne fizycznie, chcące poprawić swoją kondycję i sprawność fizyczną.

Planer treningowy będzie wykorzystany w konkretnym modelu biznesowym:
- **Model B2C (Business-to-Consumer):**  
  Aplikacja jest dostępna dla indywidualnych użytkowników jako darmowa usługa.

W dłuższej perspektywie aplikacja może generować przychody poprzez:
- Sprzedaż wersji premium,
- Reklamy partnerskie,
- Współpracę z trenerami, dietetykami i influencerami.

## Użyte Technologie
- **Język programowania:** C#
- **Framework:** WinForms
- **Baza danych:** MySQL, Access

## Lista Funkcjonalności
1. **Rejestracja i logowanie użytkownika**  
   - Możliwość założenia konta i bezpiecznego logowania się do aplikacji.

2. **Tworzenie planu treningowego**  
   - Użytkownik może konfigurować własne plany, korzystając z gotowej biblioteki ćwiczeń ze wskazaną ilością serii, czasem przerwy pomiędzy seriami, liczbą powtórzeń.
   - Możliwość skorzystania z gotowych sugestii proponowanych przez aplikację.

3. **Śledzenie postępów**  
   - System zapisuje wykonane treningi i umożliwia analizę progresu w czasie.
   - Użytkownik otrzymuje motywacyjne nagrody, np. medal po ukończeniu treningu.

## Instalacja i Uruchomienie

### Wymagania
- .NET SDK 8.0 lub wyższy
- Windows 10/11
- (opcjonalnie) Visual Studio 2022/2023 z dodatkiem "Desktop Development with C#"

### Instrukcja instalacji:
```bash
# Klonowanie repozytorium
git clone https://github.com/Kamo452/PlannerTreningowy

# Przejście do katalogu
cd PlannerTreningowy

# Uruchomienie aplikacji
dotnet run
```

### Uruchomienie przez Visual Studio:
1. Otwórz plik `.sln` (jeśli istnieje) lub `.csproj` w Visual Studio.
2. Wybierz tryb uruchomienia jako **Windows Application**.
3. Kliknij **Start (F5)**.

---

## Opis Architektury
Projekt został zaprojektowany zgodnie z zasadami **programowania obiektowego**:

- **Hermetyzacja:** Prywatne pola i publiczne metody dostępu.
- **Dziedziczenie:** Klasy bazowe i klasy dziedziczne dla różnych typów ćwiczeń i planów.
- **Polimorfizm:** Wspólny interfejs dla różnych kategorii ćwiczeń.


