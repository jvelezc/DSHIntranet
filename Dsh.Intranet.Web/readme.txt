﻿In order to use the Intranet template, you'll need to enable Windows authentication
and disable Anonymous authentication.

IIS 7 & IIS 8
1. Open IIS Manager and navigate to your website.
2. In Features View, double-click Authentication.
3. On the Authentication page, select Windows authentication. If Windows
   authentication is not an option, you'll need to make sure Windows authentication
   is installed on the server.

      To enable Windows authentication on Windows:
      a) In Control Panel open "Programs and Features".
      b) Select "Turn Windows features on or off".
      c) Navigate to Internet Information Services > World Wide Web Services > Security
         and make sure the Windows authentication node is checked.

      To enable Windows authentication on Windows Server:
      a) In Server Manager, select Web Server (IIS) and click Add Role Services
      b) Navigate to Web Server > Security
         and make sure the Windows authentication node is checked.

4. In the Actions pane, click Enable to use Windows authentication.
5. On the Authentication page, select Anonymous authentication.
6. In the Actions pane, click Disable to disable anonymous authentication.

IIS Express
1. Click on your project in the Solution Explorer to select the project.
2. If the Properties pane is not open, open it (F4).
3. In the Properties pane for your project:
 a) Set "Anonymous Authentication" to "Disabled".
 b) Set "Windows Authentication" to "Enabled".



 Example for html recommended by CIO office. I am not really a fan..
 
	<div class="content_left_column">

		<div class="cleaner"></div>

		<div class="add_padding">

			<div class="container_style_a">
				<h4>Container Style A</h4>
				<div class="add_padding">
					<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. In eu odio sem, non faucibus lectus. Maecenas et lacus et nisl volutpat semper a a magna. Curabitur aliquam risus sit amet mauris sagittis fermentum. Praesent ut pellentesque mauris. Mauris semper varius fringilla. Nam eget sagittis elit. Ut eleifend, ipsum non sagittis tempor, tellus dui fermentum risus, eu tempus lacus nisl vel augue. Proin lacus massa, varius a dictum ac, bibendum at ligula. Phasellus porttitor sollicitudin semper. In malesuada, magna ac consequat consectetur, nisi elit molestie magna, sed hendrerit turpis mi mattis massa. Proin in ante nec enim rutrum mattis. Curabitur tempus, nunc in posuere blandit, libero odio consectetur quam, eget sollicitudin tortor ante eget urna. Etiam in massa quis elit aliquet lacinia. Quisque semper rutrum leo, nec condimentum odio suscipit eget. Etiam blandit sapien vel mi bibendum auctor. </p>
				</div>
			</div>

			<div class="container_style_b">
				<h4>Container Style B</h4>
				<div class="add_padding">
					<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. In eu odio sem, non faucibus lectus. Maecenas et lacus et nisl volutpat semper a a magna. Curabitur aliquam risus sit amet mauris sagittis fermentum. Praesent ut pellentesque mauris. Mauris semper varius fringilla. Nam eget sagittis elit. Ut eleifend, ipsum non sagittis tempor, tellus dui fermentum risus, eu tempus lacus nisl vel augue. Proin lacus massa, varius a dictum ac, bibendum at ligula. Phasellus porttitor sollicitudin semper. In malesuada, magna ac consequat consectetur, nisi elit molestie magna, sed hendrerit turpis mi mattis massa. Proin in ante nec enim rutrum mattis. Curabitur tempus, nunc in posuere blandit, libero odio consectetur quam, eget sollicitudin tortor ante eget urna. Etiam in massa quis elit aliquet lacinia. Quisque semper rutrum leo, nec condimentum odio suscipit eget. Etiam blandit sapien vel mi bibendum auctor. </p>
				</div>
			</div>

			<div class="container_style_c">
				<h4>Container Style C</h4>
				<div class="add_padding">
					<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. In eu odio sem, non faucibus lectus. Maecenas et lacus et nisl volutpat semper a a magna. Curabitur aliquam risus sit amet mauris sagittis fermentum. Praesent ut pellentesque mauris. Mauris semper varius fringilla. Nam eget sagittis elit. Ut eleifend, ipsum non sagittis tempor, tellus dui fermentum risus, eu tempus lacus nisl vel augue. Proin lacus massa, varius a dictum ac, bibendum at ligula. Phasellus porttitor sollicitudin semper. In malesuada, magna ac consequat consectetur, nisi elit molestie magna, sed hendrerit turpis mi mattis massa. Proin in ante nec enim rutrum mattis. Curabitur tempus, nunc in posuere blandit, libero odio consectetur quam, eget sollicitudin tortor ante eget urna. Etiam in massa quis elit aliquet lacinia. Quisque semper rutrum leo, nec condimentum odio suscipit eget. Etiam blandit sapien vel mi bibendum auctor. </p>
				</div>
			</div>

			<h1 class="add_icon_blue_arrow_right">Heading H1</h1>

			<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. In eu odio sem, non faucibus lectus. Maecenas et lacus et nisl volutpat semper a a magna. Curabitur aliquam risus sit amet mauris sagittis fermentum. Praesent ut pellentesque mauris. Mauris semper varius fringilla. Nam eget sagittis elit. Ut eleifend, ipsum non sagittis tempor, tellus dui fermentum risus, eu tempus lacus nisl vel augue. Proin lacus massa, varius a dictum ac, bibendum at ligula. Phasellus porttitor sollicitudin semper. In malesuada, magna ac consequat consectetur, nisi elit molestie magna, sed hendrerit turpis mi mattis massa. Proin in ante nec enim rutrum mattis. Curabitur tempus, nunc in posuere blandit, libero odio consectetur quam, eget sollicitudin tortor ante eget urna. Etiam in massa quis elit aliquet lacinia. Quisque semper rutrum leo, nec condimentum odio suscipit eget. Etiam blandit sapien vel mi bibendum auctor. </p>

			<h2 class="add_icon_blue_arrow_right">Heading H2</h2>

			<p>Nam ultrices vulputate orci id faucibus. Sed eget massa ut nulla sodales ullamcorper nec vel nisi. Aenean ultricies diam sit amet ligula ullamcorper lobortis. Sed in risus at dolor commodo gravida. Aenean dolor neque, porta non ultricies ac, vestibulum ut mauris. Curabitur lorem nisi, mattis vel posuere quis, sodales at est. Mauris sagittis tristique blandit. Integer purus sapien, pulvinar ac tempor eu, consectetur lacinia orci. Ut vehicula condimentum ipsum, ac sollicitudin nibh vehicula eget. In egestas dolor vel leo cursus tincidunt. Aenean eget dolor nunc, eget tincidunt erat. Aenean sed nunc metus. Morbi quam sem, vehicula at fermentum ac, commodo in nisl. </p>

			<h3 class="">Heading H3</h3>

			<p>Sed a elit enim, ac condimentum enim. Nulla ornare interdum pellentesque. Quisque id accumsan diam. Nam euismod ultrices augue, tristique posuere dui commodo sit amet. Nulla ornare lobortis tincidunt. Sed vitae arcu urna. Integer ante nulla, gravida elementum condimentum ornare, varius eget dolor. </p>

			<h4 class="">Heading H4</h4>

			<p>In hac habitasse platea dictumst. Vestibulum purus neque, suscipit eget porta ut, tincidunt ac magna. Donec sed enim id neque ullamcorper vulputate. Sed a elit enim, ac condimentum enim. Nulla ornare interdum pellentesque. Quisque id accumsan diam. </p>

			<div class="cleaner"></div>

		</div><!--end add padding-->
	</div><!--end content left column-->

	<div class="content_right_column">

		<div class="container_style_d style_d_gradient">
			<h5 class="add_icon_orange_rss">Container Style D
				<div class="style_d_triangle"></div>
			</h5>
			<div class="add_padding">
				<p>To add the gradient, add class "style_d_gradient" to the container. To add the triangle, add a div with class "style_d_triangle".</p>
				<p>In malesuada, magna ac consequat consectetur, nisi elit molestie magna, sed hendrerit turpis mi mattis massa. Proin in ante nec enim rutrum mattis. Curabitur tempus, nunc in posuere blandit, libero odio consectetur quam, eget sollicitudin tortor ante eget urna. Etiam in massa quis elit aliquet lacinia. Quisque semper rutrum leo, nec condimentum odio suscipit eget. Etiam blandit sapien vel mi bibendum auctor. </p>
			</div>
		</div>

		<div class="container_style_d">
			<h5>Container Style D</h5>
			<div class="add_padding">
				<p>Proin lacus massa, varius a dictum ac, bibendum at ligula. Phasellus porttitor sollicitudin semper. In malesuada, magna ac consequat consectetur, nisi elit molestie magna, sed hendrerit turpis mi mattis massa. Proin in ante nec enim rutrum mattis. Curabitur tempus, nunc in posuere blandit, libero odio consectetur quam, eget sollicitudin tortor ante eget urna. Etiam in massa quis elit aliquet lacinia. Quisque semper rutrum leo, nec condimentum odio suscipit eget. Etiam blandit sapien vel mi bibendum auctor. </p>
			</div>
		</div>

		<div class="container_style_e">
			<h5>Container Style E</h5>
			<div class="add_padding">
				<p>Proin lacus massa, varius a dictum ac, bibendum at ligula. Phasellus porttitor sollicitudin semper. In malesuada, magna ac consequat consectetur, nisi elit molestie magna, sed hendrerit turpis mi mattis massa. Proin in ante nec enim rutrum mattis. Curabitur tempus, nunc in posuere blandit, libero odio consectetur quam, eget sollicitudin tortor ante eget urna. Etiam in massa quis elit aliquet lacinia. Quisque semper rutrum leo, nec condimentum odio suscipit eget. Etiam blandit sapien vel mi bibendum auctor. </p>
			</div>
		</div>


	</div><!--End content right column-->






	


	example from corin.

<div>
		<!-- ko foreach: security -->
		<div data-bind="text: password()"></div>
		<!-- /ko -->
	</div>

<!--This is this page dependencies--> 