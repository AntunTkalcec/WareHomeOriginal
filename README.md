# WareHome

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | GitHub korisničko ime
------------  | ------------------- | ----- | ---------------------
Antun Tkalčec | atkalcec@foi.hr | 0016136241 | AntunTkalcec
Karlo Habdija | khabdija@foi.hr | 0016136257 | khabdija
Kristijan Stručić | kstrucic@foi.hr | 0016137051 | Kristijanstr

## Opis domene
WareHome je aplikacija koja se koristi za praćenje količine namirnica i potrošnih stvari koje trenutno korisnik ima kod kuće. U nju korisnik može unijeti koju količinu nekog proizvoda ima kod kuće (npr. Šećera), te nakon što određenu količinu nekog proizvoda potroši, to upiše u aplikaciju. Iz toga, aplikacija mu prikaže koliko još određenog proizvoda mu je ostalo kod kuće. Nadalje, korisnik u aplikaciju može upisati željenu optimalnu količinu određene namirnice, te kada količina te namirnice padne ispod postavljenog praga, aplikacija će korisnika podsjetiti da tu namirnicu mora kupiti sljedeći put kad ide u dućan. Uz to, aplikacija analizira potrošnju određenog proizvoda, te iz toga procjenjuje kada će kojeg proizvoda ponestati. Korisnik, također, u aplikaciju može upisati raspored odlaska u dućan, pa će ga aplikacija na dan odlaska u kupovinu podsjetiti, te izlistati namirnice koje su ispod optimalnog praga. Osim svega toga, korisnik može sam upisivati svoju listu za kupovinu, koja može biti privatna ili dijeljena s domaćinstvom.


## Specifikacija projekta

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Prijava i odjava | Za pristup aplikaciji potrebno je da korisnik stvori račun i na njega se prijavi. | Antun Tkalčec 
F02 | Upis namirnica | Upisivanje imena, količine, optimalne količine i cijene namirnica te dućana gdje se namirnica kupuje. | Antun Tkalčec
F03 | Pregled i uređivanje popisa namirnica | Pregledavanje, dodavanje ili brisanje namirnica koje su upisane. | Antun Tkalčec
F04 | Spremanje trenutnog stanja u PDF | Korisnik može u PDF spremiti izvješća o trenutnom stanju artikala, kao i statistike korištenja artikala. | Antun Tkalčec
F05 | Izrada i uređivanje rasporeda odlaska u kupovinu | Upis i izmjena generalnih termina odlaska u kupovinu. | Karlo Habdija
F06 | Izrada liste za kupovinu | Izrada popisa namirnica koje želimo kupiti, a nisu prethodno upisane ili ih nemamo kod kuće. | Karlo Habdija
F07 | Pregled i uređivanje liste za kupovinu | Pregledavanje, dodavanje ili brisanje namirnica sa liste za kupovinu. | Karlo Habdija
F08 | Predviđanje potrošnje namirnica | Temeljem potrošnje u posljednjih 6 mjeseci računa se kada će koje namirnice nestati, te na zahtjev korisnika se ispisuje izvješće s navedenim podacima. | Karlo Habdija
F09 | Odabir načina ispisa liste za kupovinu | Lista može biti ispisana prema trgovini, cijeni ili količini (uzlazno ili silazno) | Kristijan Stručić
F10 | Ispis liste za kupovinu | Aplikacija prije upisanog termina odlaska u trgovinu ili zahtjevom korisnika ispisuje namirnice čija količina je ispod optimalnog praga te namirnice upisane na listu za kupovinu. | Kristrijan Stručić
F11 | Slanje podsjetnika na email | U vrijeme kada je definiran odlazak u kupovinu, korisniku se na email šalje podsjetnik sa popisom svih proizvoda na listi. | Kristijan Stručić
F12 | Izrada domaćinstva | Korisnik izrađuje obiteljsko domaćinstvo koje može koristiti više korisnika. | Kristijan Stručić
F13 | Prijava problema | Korisnik putem aplikacije može developerima prijaviti neki bug ili predložiti novu funkcionalnost. | Kristijan Stručić


## Tehnologije i oprema
.NET (Visual Studio), GitHub, GitHub Classroom, MS Office 365, MSSQL, Draw.io, Visual Paradigm, SourceTree
  
  
Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).
