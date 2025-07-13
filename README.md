## PlannerTreningowy

### Temat i Cel Biznesowy
Aplikacja **PlannerTreningowy** została stworzona w celu umożliwości użytkowikom prostego tworzenia i zarządzania planami treningowymi. Dzięki aplikacji użytkownik może zarejestrować konto, zalogować się, wybrać ćwiczenia z gotowej bazy i zbudować spersonalizowany plan treningowy. Głównym celem aplikacji jest motywowanie do aktywności fizycznej poprzez uproszczenie procesu planowania oraz monitorowanie spalonych kalorii.
Grupą docelową są osoby początkujące i średniozaawansowane, które chcą mieć pod ręką przejrzyste narzędzie do zarządzania swoim treningiem.

PlannerTreningowy będzie wykorzystany w konkretnym modelu biznesowym:
- **Model B2C (Business-to-Consumer):**  
  Aplikacja jest dostępna dla indywidualnych użytkowników jako darmowa usługa.

W dłuższej perspektywie aplikacja może generować przychody poprzez:
- Sprzedaż wersji premium,
- Reklamy partnerskie,
- Współpracę z trenerami, dietetykami i influencerami.

---

## Użyte Technologie
- **Język programowania**: C#
- **Framework**: WinForms (.NET 8.0)
- **Baza danych**: Microsoft Access (`.accdb`)

---

## Lista Funkcjonalności:

### Rejestracja i logowanie użytkownika
- Rejestracja z walidacją unikalności loginu oraz weryfikacją pustych pól
- Logowanie z obsługą błędów i przekierowaniem do głównego planera

### Tworzenie planu treningowego
- Możliwość wyboru ćwiczeń z lokalnej bazy danych
- Wyświetlanie szczegółowego opisu ćwiczenia oraz grupy mięśni, do której należy
- Dynamiczne dodawanie ćwiczeń do planu
- Podgląd aktualnego planu
- Podgląd szacowanych spalonych kalorii w danej serii ćwiczenia

### Eksport planu do pliku o formacie .txt
- Możliwość zapisania gotowego planu treningowego z imieniem użytkownika i podsumowaniem

---

## Instalacja i Uruchomienie

### Wymagania systemowe:
- Windows 10/11
- .NET SDK 8.0+

### Instrukcja uruchomienia:
```bash
# Klonowanie repozytorium
git clone https://github.com/Kamo452/PlannerTreningowy

# Przejście do folderu
cd PlannerTreningowy

# Uruchomienie (jeśli projekt jest konsolowy)
dotnet run
```

**Alternatywnie w Visual Studio:**
- Otwórz plik `.sln` lub `.csproj`
- Ustaw projekt jako `Startowy`
- Kliknij "Start" lub wciśnij `F5`

---

## Opis Architektury

Projekt oparty jest na paradygmacie programowania obiektowego:

- **Hermetyzacja**: Własności klas prywatne lub publiczne z dostępem przez get/set
- **Dziedziczenie i interfejsy**: Klasa Cwiczenie dziedziczy po klasie abstrakcyjnej CwiczenieBase i implementuje interfejs ICwiczenie, co umożliwia elastyczność i rozbudowę projektu w przyszłości.
- **Polimorfizm**: Realizowany jest poprzez wykorzystanie ToString() w celu  wyświetlania obiektów w ListBox
- **Klasa Cwiczenie** odzwierciedla strukturę bazy danych (Nazwa, Grupa, Opis, Kcal)
- **Klasa Database** zawiera metody dostępu do bazy danych

---

## Diagram UML
- **Diagram klas UML** ze strukturą naszego projektu: (uml/uml.png)
