# TodoList
Applicativo per la gestione di una lista di attivit� da fare. 
L'applicativo dovr� essere usufruibile tramite web e dovr� essere accessibile tramite autenticazione.

## Funzionalit�
L'applicativo deve permettere di:
- Creare un'attivit�
- Modificare un'attivit�
- Eliminare un'attivit�
- Completare un'attivit�

## Struttura
### Pagina di autenticazione
La prima pagina (in caso non si fosse autenticati), � la pagina di autenticazione.
Questa pagina presenta un form con email e password.
La login pu� essere inoltre effettuata con google e facebook.

### Pagina TodoList
Pagina accessibile tramite autenticazione.
Contiene la lista delle attivit�.

## Entit�
Utenti
- Email: Email dell'utente
- Password: Password dell'utente, deve essere criptata
- Ultimo accesso: Data e orario di ultimo accesso dell'utente

Attivita
- Titolo: Titolo dell'attivit�
- Testo: Descrizione dell'ativit�
- IdUtCreazione: L'id dell'utente che ha creato l'attivit�
- DataCreazione: Data in cui � stata creata l'attivit�
- DataUltModifica: Data dell'ultima modifica dell'attivit�
- Completato: Booleano che dice se l'attivit� sia completata o meno.