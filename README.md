Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).

# WareHome

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Antun Tkalčec | atkalcec@foi.hr | 0016136241 | AntunTkalcec
Karlo Habdija | khabdija@foi.hr | 0016136257 | khabdija
Kristijan Stručić | kstrucic@foi.hr | 0016137051 | Kristijanstr

## Opis domene
WareHome je aplikacija koja se koristi za praćenje količine namirnica i potrošnih stvari koje trenutno korisnik ima kod kuće. U nju korisnik može unijeti koju količinu nekog proizvoda ima doma (npr. Šećera), te nakon što određenu količinu nekog proizvoda potroši, to upiše u aplikaciju. Iz toga, aplikacija mu prikaže koliko još određenog proizvoda mu je ostalo kod kuće. Nadalje, korisnik u aplikaciju može upisati željenu optimalnu količinu određene namirnice, te kada količina te namirnice padne ispod postavljenog praga, aplikacija će korisnika podsjetiti da tu namirnicu mora kupiti sljedeći put kad ide u dućan. Korisnik, također, u aplikaciju može upisati raspored odlaska u dućan, pa će ga aplikacija nekoliko sati prije termina kupovanja namirnica podsjetiti, te izlistati namirnice koje su ispod optimalnog praga. Osim svega toga, korisnik može sam upisivati svoju listu za kupovinu, koja može biti javna ili zaključana iza lozinke.


## Specifikacija projekta

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Prijava i odjava | Za pristup aplikaciji potrebno je da korisnik stvori račun i na njega se prijavi. | Antun Tkalčec 
F02 | Upis namirnica | Upisivanje imena, količine, optimalne količine i cijene namirnica te dućana gdje se namirnica kupuje. | Antun Tkalčec
F03 | Pregled i uređivanje popisa namirnica | Pregledavanje, dodavanje ili brisanje namirnica koje su upisane. | Antun Tkalčec
F04 | Izrada i uređivanje rasporeda odlaska u kupovinu | Upis i izmjena generalnih termina odlaska u kupovinu. | Karlo Habdija
F05 | Izrada liste za kupovinu | Izrada popisa namirnica koje želimo kupiti, a nisu prethodno upisane ili ih nemamo kod kuće. | Karlo Habdija
F06 | Pregled i uređivanje liste za kupovinu | Pregledavanje, dodavanje ili brisanje namirnica sa liste za kupovinu. | Karlo Habdija
F07 | Predviđanje potrošnje namirnica | Temeljem potrošnje u posljednjih 6 mjeseci računa se kada će koje namirnice nestati, te na zahtjev korisnika se ispisuje izvješće s navedenim podacima. | Karlo Habdija
F08 | Odabir načina ispisa liste za kupovinu | Lista može biti ispisana prema trgovini, cijeni ili količini (uzlazno ili silazno) | Kristijan Stručić
F09 | Ispis liste za kupovinu | Aplikacija prije upisanog termina odlaska u trgovinu ili zahtjevom korisnika ispisuje namirnice čija količina je ispod optimalnog praga te namirnice upisane na listu za kupovinu. | Kristrijan Stručić
F10 | Slanje podsjetnika na email | U vrijeme kada je definiran odlazak u kupovinu, korisniku se na email šalje podsjetnik sa popisom svih proizvoda na listi. | Kristijan Stručić
F11 | Prijava problema | Korisnik putem aplikacije može developerima prijaviti neki bug ili predložiti novu funkcionalnost. | Kristijan Stručić
F12 | Izrada domaćinstva | ... | Kristijan Stručić
F13 | Spremanje trenutnog stanja u PDF | ... | Antun Tkalčec

## Tehnologije i oprema
.NET (Visual Studio), GitHub, GitHub Classroom, MS Word, MSSQL, Draw.io, Visual Paradigm
