﻿# Érték és referencia típusok

Érték típusok: az egyszerű változó típusok (int,string,char,boolean)
Referencia típusok: Minden más típus (tömbök,objektumok stb)

**A program futása során használt memóriák:stack és a heap**

       Stack memória                                                         Heap (halom)
      +-------------------------------------------+                         +------------------------------------------+
      |                                           |                         | +----------------------------------------|
      +-------------------------------------------+                         | |                                       ||
      ||                                         ||            +--------------> tömb                                  ||
      || a                                       ||            |              +----------------------------------------|
      ||                                         ||            |            | +----------------------------------------|
      |-------------------------------------------|            |            | |tömb2                                  ||
      |-------------------------------------------|            |    +--------<+                                       ||
     -----------------------^                    ||            |    |       | +----------------------------------------+
      || b                                       ||            |    |       |                                          |
      ||                                         ||            |    |       |                                          |
      +-------------------------------------------+            |    |       |                                          |
      | +---------------------------------------+ |            |    |       |                                          |
      | |referencia a tömbre                    +--------------+    |       |                                          |
      | +---------------------------------------+ |                 |       |                                          |
      | +---------------------------------------+ |                 |       |                                          |
      | | referencia a tömbre                   +-------------------+       |                                          |
      | +---------------------------------------+ |                         |                                          |
      |                                           |                         |                                          |
      |                                           |                         |                                          |
      |                                           |                         |                                          |
      |                                           |                         |                                          |
      |                                           |                         |                                          |
      |                                           |                         |                                          |
      |                                           |                         |                                          |
      |                                           |                         |                                          |
      |                                           |                         |                                          |
      |                                           |                         |                                          |
      |                                           |                         |                                          |
      |                                           |                         |                                          |
      |                                           |                         |                                          |
      |                                           |                         |                                          |
      |                                           |                         |                                          |
      |                                           |                         |                                          |
      |                                           |                         |                                          |
      +-------------------------------------------+                         +------------------------------------------+

Az egyszerű típusok a stack memóriába kerülnek, az többi a heap memóriába, a stack-be csak egy az adott típusra mutató hivatkozás(referencia) kerül.
