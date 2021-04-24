Added new team member: Andreea
Added new team member: Diana
Added new team member: Georgiana

// introduceti aici mesajul de la pct 6

Trebuie sa acceptati invitatia care v-a fost trimisa pe mail de la mine. 
Nu va faceti branch-uri separate ca nu le pot vedea. Branchurile sunt facute cu Prenume_Branch (Diana_Branch Paul_Branch si Georgiana_Branch)

1.Se copiaza link-ul de la repository (Butonul verde cu inscriptia CODE -> langa link este o casuta care copiaza link-ul de la repository)

2.Se deschide cmd in folderul din calculator unde se va clona repository-ul 

3.git clone (aici se pune link-ul)

4.Din folder-ul in care se afla proiectul se deschide din nou un cmd si se introduc urmatoarele comenzi 


git config --global user.name "John Doe" (Se introduce username-ul de la GitHub)

git config --global user.email johndoe@example.com (email-ul de la contul de GitHub)

git fetch

git checkout Prenume_Branch (Fiecare dintre noi are un branch deja facut special pentru el. Puteti vizualiza branch-ul in GitHub)

git status (pentru a vizualiza branch-ul in care va aflati -> branch-ul trebuie sa fie cel specificat in GitHub adica Prenume_Branch)


5.Deschidere README.md cu ajutorul unui editor de text

6.Se introduce in README mesajul "Added new team member: NUME PRENUME"

7.In cmd se introduc urmatoarele comenzi (cmd este deschis din folder-ul sursa al proiectului)


git add .

git commit -m "Verify NUME branch"

git push