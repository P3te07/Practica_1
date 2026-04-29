# Sistem de evidență a unei săli de fitness

## Descriere succintă a temei

Sistemul WPF de evidență a unei săli de fitness este un proiect sub forma unei aplicații desktop, pentru a facilita procesul de gestionare a resurselor dintr-o sală de fitness. Aplicația pune accent pe ușurința de utilizare și adaptare a utilizatorului, aducând funcționalități de bază pentru introducerea, modificarea și extragerea datelor despre clienți, abonamente și detalii.
Documentarea proiectului are ca scop definirea în prealabil a tuturor structurilor, relațiilor și tehnologiilor utilizate în realizarea aplicației.

## Definirea structurii și relațiilor dintre tabele

În baza de date relațională, MSSQL Server, vor exista 3 tabele principale, în care se vor stoca toate înregistrările de date precum cllienții, abonamentele și înregistrările.
Tabelele principale sunt:

- Clienti
- Abonamente
- InregistrareAbonament

Tabelul de înregistrare a abonamentelor va juca rol de legătură pentru tabelele principale Clienti și Abonamente. Prin intermediul PK-urilor din tabelele principale, se vor realiza conexiuni cu FK-uri din tabelul InregistrareAbonament, așadar, structura poate fi vizualizată conform figurii 1.

```
InregistrareAbonament                         Clienti
-Id                                      /--->-IdClient
-IdClient    ----------------------------|    -NumePrenume
-IdAbonament ---|                             -DataNasterii
-DataStart      |                             -Telefon
-DataFinish     |                             -Email
                |
Abonamente      |
-IdAbonament <--/
-Tip
-Pret
-GradAcces
                        Figura 1: ERD a bazei de date
```

## Planificarea structurii ferestrei UI

Fereastra de User Interface va folosi un design intuitiv și specific aplicațiilor desktop WPF.
Searchbar-ul va fi amplasat în partea din stânga-sus a ecranului, iar în dreapta, butoanele de căutare, resetare și refresh.
La mijlocul ferestrei, va fi amplasat DataViewGrid-ul ce va oferi forma necesară pentru afișarea datelor.
În partea de jos a paginii, se va afla formularul pentru introducerea și modificarea datelor din baza de date. Acest formular va fi personalizat pentru ficare tabel, astfel ficare entitate va avea pagina specifică, cu câmpurile specifice din formular.
