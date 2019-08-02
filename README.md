# LINQPad script for generating passhprases in czech language

* uses CSPRNG (cryptographically secure random generator), pure .NET, no other dependencies
* two dictionaries, one contains 72 000 common words, another larger contains 320 000 czech words
* 3 modes: regular, simple, stealth
* simple mode is just words separated by spaces
* regular has additional complexity: some words might be uppercase, some words might be replaced by long numbers, separators are randomly chosen special characters
* stealth mode generates phrases that look like regular sentences
* contains also script for transforming the dictionary for javascript version
* simplified javascript version is running at https://urza.cc/hesla
