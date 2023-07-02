# Polish version README

**Jest to projekt na zaliczenie przedmiotu: "Programowanie obiektowe"!**

**Treść zadania**

Zaprojektuj i zaimplementuj program z interfejsem okienkowym typu Paint.

Przykładowe funkcjonalności programu to:
* Panel do rysowania:
  - Komponent panel
  - Graphics g;
  - g = panel_Draw.CreateGraphics();
* Zmiana kolorów:
  - pen.Color = Color.Purple;
  - colorDialog:
    - ColorDialog c = new ColorDialog(); if(c.ShowDialog()==DialogResult.OK) { btn_PenColor.BackColor = c.Color; }
* Zmiana grubości pędzla
* Zapisywanie rysunków z menu:
  - SaveFileDialog saveFileDialog1 = new SaveFileDialog();
  - saveFileDialog1.Filter = "JPeg Image|*.jpg| Bitmap Image|*.bmp|Gif Image|*.gif";
  - saveFileDialog1.Title = "Save an Image File";
  - saveFileDialog1.ShowDialog()

Powyższe funkcjonalności są przykładowe, im więcej zaimplementowanych tym lepiej. 
Nie ma dokładnych wytycznych co do interfejsu programu, należy go zaplanować i zaimplementować w taki sposób, aby był intuicyjny i wygodny dla użytkownika.
W projekcie powinna być możliwość wyświetlania informacji o autorze programu, np. w postaci wyskakującego Message Boxa.

Do projektu powinna być dołączona dokumentacja zawierająca 3 części:
* Instrukcja dla użytkownika, wymieniająca zaimplementowane funkcjonalności i opisująca sposób skorzystania z nich (np. miejsce kliknięcia, użycie odpowiedniej kontrolki.
* Dokumentacja techniczna wymieniająca elementy i właściwości języka z których korzystał autor programu (dobrze się pochwalić!).
* Samoocenę zawierającą proponowaną ocenę z krótkim uzasadnieniem (np. czy wszystko działa poprawnie, czy brakuje jakiejś funkcjonalności).

# English version README

> Translated with www.DeepL.com/Translator

**This is a project for course credit: "Object Oriented Programming"!**

**Content of the task:**

Design and implement a program with a Paint type window interface.

Examples of program functionality include:
* A panel for drawing:
  - Component panel
  - Graphics g;
  - g = panel_Draw.CreateGraphics();
* Changing colors:
  - pen.Color = Color.Purple;
  - colorDialog:
  - ColorDialog c = new ColorDialog(); if(c.ShowDialog()==DialogResult.OK) { btn_PenColor.BackColor = c.Color; }
* Changing the brush thickness
* Saving drawings from the menu
  - SaveFileDialog saveFileDialog1 = new SaveFileDialog();
  - saveFileDialog1.Filter = "JPeg Image|*.jpg| Bitmap Image|*.bmp|Gif Image|*.gif."
  - saveFileDialog1.Title = "Save an Image File";
  - saveFileDialog1.ShowDialog()

The above functionalities are examples, the more implemented the better. 
There are no exact guidelines for the program interface, it should be planned and implemented in such a way that it is intuitive and convenient for the user.
The project should be able to display information about the author of the program, for example, in the form of a pop-up Message Box.

The project should be accompanied by documentation containing 3 parts:
* A user guide, listing the implemented functionalities and describing how to use them (e.g., where to click, using the appropriate control.
* Technical documentation listing the elements and features of the language used by the program author (good to brag!).
* A self-assessment including a proposed evaluation with a brief rationale (e.g., does everything work correctly or is some functionality missing).

