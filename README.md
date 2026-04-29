# Sistem de evidență a unei săli de fitness


## Descriere succintă a temei

Sistemul WPF de evidență a unei săli de fitness este un proiect sub forma unei aplicații desktop, pentru a facilita procesul de gestionare a resurselor dintr-o sală de fitness. Aplicația pune accent pe ușurința de utilizare și adaptare a utilizatorului, aducând funcționalități de bază pentru introducerea, modificarea și extragerea datelor despre clienți, abonamente și detalii. 
Documentarea proiectului are ca scop definirea în prealabil a tuturor structurilor, relațiilor și tehnologiilor utilizate în realizarea aplicației.


## Definirea structurii tabelelor

În baza de date relațională, MSSQL Server, vor exista 3 tabele principale, în care se vor stoca toate înregistrările de date precum cllienții, abonamentele și înregistrările. 
Tabelele principale sunt: 
- Clienti
- Abonamente
- InregistrareAbonament

Tabelul de înregistrare a abonamentelor va juca rol de legătură pentru tabelele principale Clienti și Abonamente. Prin intermediul PK-urilor din tabelele principale, se vor realiza conexiuni cu FK-uri din tabelul InregistrareAbonament, așadar, structura poate fi vizualizată conform figurii 1. 

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

