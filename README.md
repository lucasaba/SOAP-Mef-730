SOAP-Mef-730
============

Questo progetto è un piccolo programma per l'invio asincrono del file XML
con il flusso 730 per gli studi medici convenzionati.

Prima di tutto...
=================

Prima di lanciare l'eseguibile è necessario o di importare il progetto in visual studio
è necessario creare il file App.config nella cartellla WinMef730.

Par fare questo, basta rinominare il file App.config.dist in App.config.

Ringraziamenti
==============

La logica del codice non è mia. La devo con tutto il cuore a una serie di post su 
[VisualBasic.it](http://www.visual-basic.it/Forum/tabid/151/aft/42746/Default.aspx#.WIjd9HXhDCI)
e, soprattutto, all'ottimo articolo, accompagnato dal codice, di Giulio Martino che
potete leggere [qui](http://www.visual-basic.it/Dettaglio/tabid/132/ArticleId/1804/Invio-dati-a-Web-Service-con-MTOM.aspx#.WIjch3XhDCJ).

Per ora il programma prende il file zip e lo invia al MEF per il trattamento dei dati.

Non ci sono ancora controlli di alcun tipo. E, inoltre, non c'è alcuna gestione delle ricevute che deve 
essere fatta direttamente dal sito.

Grazie mille al lavoro di tutti quelli che hanno partecipato alla discussione su http://www.visual-basic.it
