This is a simple fizzbuzz example showing the difference between switch statements and if else statements.

Some basic tests show that it's a little faster than an if/else implementation. You'll notice I've included a stopwatch, I have found that for a count of 10000 a switch/case implementation will run in ~65milliseconds. Whereas the equivalent if/else will run in around ~70milliseconds. There's not much in it, and I haven't properly load tested it (which I might do next... 🤔) but the switch does seem to be consistently quicker.

Stopwatch is a useful feature for testing performance of methods.

You might want to try removing the `continue` from the FizzElse version, and see it run slower...
