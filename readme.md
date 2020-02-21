This is a simple fizzbuzz example showing the difference between switch statements and if else statements counting to 10k.

This implementation uses a stopwatch and logs the output to the console and to a file. If you run the `./benchmark.sh` script this will execute each version of the programme 50 times and then run average.csx to calculate an average result. The profile I have generated on my machine is as follows:

```
Average Speed of Switch  is             63.46 ms
Average Speed of IfElseCont is          62.03 ms
Average Speed of If Else is             60.62 ms
Average Speed of If Only is             73.35 ms
Average Speed of If Cont is             73.55 ms
```
