# TodoList
Applicativo per la gestione di una lista di attività da fare. 
L'applicativo dovrà essere usufruibile tramite web e dovrà essere accessibile tramite autenticazione.

## Funzionalità
L'applicativo deve permettere di:
- Creare un'attività
- Modificare un'attività
- Eliminare un'attività
- Completare un'attività

## Struttura
### Pagina di autenticazione
La prima pagina (in caso non si fosse autenticati), è la pagina di autenticazione.
Questa pagina presenta un form con email e password.
La login può essere inoltre effettuata con google e facebook.

### Pagina TodoList
Pagina accessibile tramite autenticazione.
Contiene la lista delle attività.

## Entità
Utenti
- Email: Email dell'utente
- Password: Password dell'utente, deve essere criptata
- Ultimo accesso: Data e orario di ultimo accesso dell'utente

Attivita
- Titolo: Titolo dell'attività
- Testo: Descrizione dell'atività
- IdUtCreazione: L'id dell'utente che ha creato l'attività
- DataCreazione: Data in cui è stata creata l'attività
- DataUltModifica: Data dell'ultima modifica dell'attività
- Completato: Booleano che dice se l'attività sia completata o meno.