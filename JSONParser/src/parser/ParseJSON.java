package parser;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.PrintStream;

public class ParseJSON {

	public static void main(String[] args) {
		if (args.length != 2) {
			usage();
		}
		File inputFile = new File(args[0]);
		File outputFile = new File(args[1]);
		if (outputFile.exists()) {
			outputFile.delete();
		}
		try {
			outputFile.createNewFile();
			parseInputFile(inputFile, outputFile);
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
	
	private static class MalformedFormatException  extends Exception {

		/**
		 * 
		 */
		private static final long serialVersionUID = 1L;
		public MalformedFormatException(String arg) {
			System.err.println(arg);
		}
	}

	private static void parseInputFile(File inputFile, File outputFile) throws MalformedFormatException {
		try {
			BufferedReader reader = new BufferedReader(new FileReader(inputFile));
			PrintStream writer = new PrintStream(outputFile);
			String inputLine;
			boolean first = true;
			inputLine = reader.readLine();
			while (inputLine != null) {
				if (first) {
					writer.println("{");
					writer.println("\t\"fxdata\": {");
					first = false;
				} else {
					String[] tokens = inputLine.split("\t");
					if (tokens.length != 3) {
						System.out.println(tokens.length);
						throw new MalformedFormatException("The lines of the file should be formatted in the form: <country> <Date> <ChangePercentage>");
					}
					writer.println("\t\t\"" + tokens[0] + "\" : {");
					writer.println("\t\t\t\"date\" : " + "\"" + tokens[1] + "\",");
					writer.println("\t\t\t\"changePercentage\" : " + "\"" + tokens[2] + "\"");
				}
				inputLine = reader.readLine();
				if (inputLine == null) {
					writer.println("\t\t}");
				} else {
					writer.println("\t\t},");
				}
			}
			writer.println("\t}");
			writer.println("}");
			writer.close();
			reader.close();
		} catch(Exception e) {
			e.printStackTrace();
		}
		
	}

	private static void usage() {
		System.err.println("Usage: ParseJSON <inputFile> <outputFile>");
		System.exit(2);
	}
}
