AckTerm
=======

My fork of the "ACKTERM" at http://sourceforge.net/projects/ackterm/

"A C# .net VT/Telnet terminal emulator. The project is still very much in development but the Terminal is quite useable and fairly tolerent. It requires a c# 2 compiler. If anyone has taken this project any further, I'd love to see the results.", GEORDS - http://sourceforge.net/users/geords

New Changes in my fork

1. Provided support for ANSI Code Sequences. 

   Replaced VT220 with SCOANSI to support that of Santa Cruz Operation (SCO UNIX) OpenServer 6.
   
   With SCOANSI support, there are now 24 function keys available for the system compared to VT220 with only 4 function keys.
   
3. Modified CharSet attributes (uc_Chars.Sets.DECSG) for alternate font to fit SCOANSI

4. Set Default Size to 25,80

5. Activate uc_Mode.AutoWrap by default

6. Replaced type-unsafe collections to type-safe generic collections.

7. Support for Data Entry Automation through AutoProcess Event Handler with Command Sequence/Loader

8. Support for Back-end MySQL Database Transactions as DataSource.

9. Provided Support for Offline DataSource Emulation. 

10. Optional Cross Hair Cursor and Screen Matrix Display Support


To Do:

1. Optional support for Excel (*.XLSx) file through DataSet as an additional datasource.
