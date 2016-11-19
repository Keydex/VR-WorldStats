package parser;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.PrintStream;

public class ParseJSON {

	public static void main(String[] args) {
		if (args.length != 3) {
			usage();
		}
		File[] inputFiles = new File[args.length - 1];
		for (int i = 0; i < inputFiles.length; i++) {
			inputFiles[i] = new File(args[i]);
		}
		File outputFile = new File(args[args.length - 1]);
		if (outputFile.exists()) {
			outputFile.delete();
		}
		try {
			outputFile.createNewFile();
			parseInputFile(inputFiles, outputFile);
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

	private static void parseInputFile(File[] inputFile, File outputFile) throws MalformedFormatException {
		try {
			PrintStream writer = new PrintStream(outputFile);
			writer.println("{");
			writer.println("\t\"fxdata\": {");
			for (int i = 0; i < inputFile.length; i++) {
				BufferedReader reader = new BufferedReader(new FileReader(inputFile[i]));
				String inputLine;
				boolean first = true;
				inputLine = reader.readLine();
				inputLine = reader.readLine();
				while (inputLine != null) {
					String[] tokens = inputLine.split("\t");
					if (tokens.length != 3) {
						reader.close();
						throw new MalformedFormatException("The lines of the file should be formatted in the form: <country> <Date> <ChangePercentage>");
					}
					if (first) {
						writer.println("\t\t\"" + tokens[1] + "\" : {");
						writer.println("\t\t\t\"" + tokens[0] + "\" : {");
						writer.println("\t\t\t\t\"changePercentage\" : " + "\"" + tokens[2] + "\"");
						first = false;
					} else {
						writer.println("\t\t\t\"" + tokens[0] + "\" : {");
						writer.println("\t\t\t\t\"changePercentage\" : " + "\"" + tokens[2] + "\"");
					}
					inputLine = reader.readLine();
					if (inputLine == null) {
						writer.println("\t\t\t}");
						if (i == inputFile.length - 1) {
							writer.println("\t\t}");
						} else {
							writer.println("\t\t},");
						}	
					} else {
						writer.println("\t\t\t},");
					}
				}
				reader.close();
			}
			writer.println("\t}");
			writer.println("}");
			writer.close();
		} catch(Exception e) {
			e.printStackTrace();
		}
		
	}

	private static void usage() {
		System.err.println("Usage: ParseJSON <inputFile> <outputFile>");
		System.exit(2);
	}
}
