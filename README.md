# TrackStudyTime
Track Study Time è una semplice applicazione scritta in C# usando windows form.

Nasce da un esigenza personale di tener traccia delle ore di studio durante una giornata, l`ammontare totale delle pause, la frequenza delle pause, dati molto importanti per riuscire a vedere e massimizzare le ore di studio durante una giornata, dati utili per capire come migliorarsi e per fissarsi degli obiettivi.

L'applicazione ha infatti la possibilità di fissare un obiettivo di ore giornaliero, un massimo ammontare di minuti di pausa, che una volta superati manderanno una mail
all'utente.

Per divertimento e per riprendere la mano con PHP ho implementato un sistema REST che gestisce:

	- registrazione degli utenti
	
	- invio del tempo di studio attuale al DB
	
	- recupero del tempo studiato in quella giornata 
	  (così se accidentalmente dovessimo chiudere l`app tutti i dati sarebbero comunque al sicuro)
	
	- invio di mail quando la pausa è terminata
	
	- possibilità di aggiungere amici e visualizzare il loro tempo.
	
	-ottenere i dati e mostrare un grafico che rispecchi la situazione
	 in un periodo di tempo definito, mostri media e ore di studio totali.
	 
	 
Oltre che per divertimento sono stato spinto a creare una parte online che aggiungesse e gestisse gli amici per indurre un po' di spirito di competizione
che quindi portasse ad una ottimizzazione del tempo di studio.

L'applicazione è disponibile solo per windows ed eventualmente emulata con Wine in Linux e Mac OS.
